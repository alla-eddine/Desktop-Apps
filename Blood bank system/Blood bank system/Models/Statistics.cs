using Blood_bank_system.Db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Blood_bank_system.Models
{
    public struct StatsByDate
    {
        public string Date { get; set; }
        public int Total { get; set; }
    }

    public class Statistics : DbConnection
    {
        public int NumberCandidats;
        public int NumberActiveDonors;
        public int NumberDesactiveDonors;
        public int Number_reg;
        public int Number_reg_cp;
        public int Number_occ;
        public int Number_occ_cp;

        public List<KeyValuePair<string, int>> MagazinSangList { get; private set; }
        public List<KeyValuePair<string, int>> DonorTypesList { get; private set; }
        public List<StatsByDate> CandidatsList { get; private set; }
        public DataTable ActiveDonorList;

        public Statistics() { }

        private void GetNumbers(string filterType)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Cmd = new SqlCommand())
                {
                    Cmd.Connection = connection;

                    string dateCondition = GetDateCondition(filterType);

                    Cmd.CommandText = $"SELECT COUNT(*) FROM donors WHERE {dateCondition}";
                    NumberCandidats = (int)Cmd.ExecuteScalar();

                    Cmd.CommandText = $"SELECT COUNT(*) FROM donors WHERE DATEDIFF(DAY, donation_date, GETDATE()) > 92" +
                        $" AND {dateCondition}";
                    NumberActiveDonors = (int)Cmd.ExecuteScalar();

                    Cmd.CommandText = $"SELECT COUNT(*) FROM donors WHERE donor_poche <> 'Poche' AND {dateCondition}";
                    NumberDesactiveDonors = (int)Cmd.ExecuteScalar();

                    Cmd.CommandText = $"SELECT COUNT(*) FROM donors WHERE donor_type = 'Régulier' AND {dateCondition}";
                    Number_reg = (int)Cmd.ExecuteScalar();

                    Cmd.CommandText = $"SELECT COUNT(*) FROM donors WHERE donor_type = 'Régulier-Cp' AND {dateCondition}";
                    Number_reg_cp = (int)Cmd.ExecuteScalar();

                    Cmd.CommandText = $"SELECT COUNT(*) FROM donors WHERE donor_type = 'Occasionnel' AND {dateCondition}";
                    Number_occ = (int)Cmd.ExecuteScalar();

                    Cmd.CommandText = $"SELECT COUNT(*) FROM donors WHERE donor_type = 'Occasionnel-Cp' AND {dateCondition}";
                    Number_occ_cp = (int)Cmd.ExecuteScalar();
                }
            }
        }

        private void CandidatsAnalysis(string filterType)
        {
            CandidatsList = new List<StatsByDate>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Cmd = new SqlCommand())
                {
                    Cmd.Connection = connection;
                    string dateCondition = GetDateCondition(filterType);
                    string groupBy = filterType == "CurrentMonth"
                                    ? "FORMAT(donation_date, 'dd MMM')"
                                    : "FORMAT(donation_date, 'MMM')";

                    Cmd.CommandText = $@"
                                        SELECT {groupBy} AS period, COUNT(*) AS total_donations
                                        FROM donors
                                        WHERE {dateCondition}
                                        GROUP BY {groupBy}, MONTH(donation_date) 
                                        ORDER BY MONTH(donation_date)";

                    var Reader = Cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        CandidatsList.Add(new StatsByDate()
                        {
                            Date = Reader["period"].ToString(),
                            Total = (int)Reader["total_donations"]
                        });
                    }
                    Reader.Close();
                }
            }
        }

        private void MagazinAnalysis(string filterType)
        {
            MagazinSangList = new List<KeyValuePair<string, int>>();
            ActiveDonorList = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Cmd = new SqlCommand())
                {
                    Cmd.Connection = connection;

                    string dateCondition = GetDateCondition(filterType);

                    Cmd.CommandText = $"SELECT donor_group AS groupage, COUNT(donor_group) AS stock " +
                                      $"FROM donors WHERE donor_poche = 'Poche' AND {dateCondition} " +
                                      $"GROUP BY donor_group ORDER BY groupage";

                    var Reader = Cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        MagazinSangList.Add(new KeyValuePair<string, int>((string)Reader[0], (int)Reader[1]));
                    }
                    Reader.Close();
                }
            }
        }

        private void DonorTypes(string filterType)
        {
            DonorTypesList = new List<KeyValuePair<string, int>>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Cmd = new SqlCommand())
                {
                    Cmd.Connection = connection;

                    string dateCondition = GetDateCondition(filterType);

                    Cmd.CommandText = $"SELECT donor_type AS D_type, COUNT(donor_type) AS D_count " +
                                      $"FROM donors WHERE  {dateCondition} GROUP BY donor_type " +
                                      $"ORDER BY D_type DESC";

                    var Reader = Cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        DonorTypesList.Add(new KeyValuePair<string, int>((string)Reader[0], (int)Reader[1]));
                    }
                    Reader.Close();
                }
            }
        }

        public void LoadData(string filterType)
        {
            GetNumbers(filterType);
            CandidatsAnalysis(filterType);
            MagazinAnalysis(filterType);
            DonorTypes(filterType);
        }

        private string GetDateCondition(string filterType)
        {
            if (filterType == "CurrentMonth")
            {
                return "MONTH(donation_date) = MONTH(GETDATE()) AND YEAR(donation_date) = YEAR(GETDATE())";
            }
            else if (filterType == "CurrentQuarter")
            {
                return "DATEPART(QUARTER, donation_date) = DATEPART(QUARTER, GETDATE()) AND YEAR(donation_date) = YEAR(GETDATE())";
            }
            else if (filterType == "CurrentHalfYear")
            {
                return "((MONTH(GETDATE()) BETWEEN 1 AND 6 AND MONTH(donation_date) BETWEEN 1 AND 6) " +
                       "OR (MONTH(GETDATE()) BETWEEN 7 AND 12 AND MONTH(donation_date) BETWEEN 7 AND 12)) " +
                       "AND YEAR(donation_date) = YEAR(GETDATE())";
            }
            else if (filterType == "CurrentYear")
            {
                return "YEAR(donation_date) = YEAR(GETDATE())";
            }
            else
            {
                return "1=1"; 
            }
        }

    }
}




















/*using Blood_bank_system.Db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_bank_system.Models
{
    public struct StatsByDate 
    {
        public string Date {  get; set; }
        public int Total { get; set; }
    }

    //public struct

    public class Statistics : DbConnection
    {
        // Fields & properties
        private int NumberDays;

        public int NumberCandidats;
        public int NumberActiveDonors;
        public int NumberDesactiveDonors;

        public int Number_reg;
        public int Number_reg_cp;
        public int Number_occ;
        public int Number_occ_cp;

        public List<KeyValuePair<string, int>> MagazinSangList { get; private set; }
        public List<StatsByDate> CandidatsList { get; private set; }

        public DataTable ActiveDonorList;

        // constructor
        public Statistics() 
        {
            
        }
        // private methods
        private void GetNumbers()
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using( var Cmd = new SqlCommand())
                {
                    Cmd.Connection = connection;
                    // Total candidats number
                    Cmd.CommandText = "select count(*) from donors where YEAR(donation_date) = YEAR(GETDATE())" +
                        " and DATEDIFF(DAY, donation_date, GETDATE()) <= @NumberDays";
                    Cmd.Parameters.Add("@NumberDays", System.Data.SqlDbType.Int).Value = NumberDays;
                    NumberCandidats = (int)Cmd.ExecuteScalar();
                    // Total candidats number
                    Cmd.CommandText = "select count(*) from donors" +
                        " where DATEDIFF(DAY, donation_date, GETDATE()) > 92 and YEAR(donation_date) = YEAR(GETDATE())" +
                        " and DATEDIFF(DAY, donation_date, GETDATE()) <= @NumberDays1";
                    Cmd.Parameters.Add("@NumberDays1", System.Data.SqlDbType.Int).Value = NumberDays;
                    NumberActiveDonors = (int)Cmd.ExecuteScalar();
                    // Total candidats number
                    Cmd.CommandText = "select count(*) from donors where donor_poche <> 'Poche'" +
                        "and YEAR(donation_date) = YEAR(GETDATE()) and DATEDIFF(DAY, donation_date, GETDATE()) <= @NumberDays2";
                    Cmd.Parameters.Add("@NumberDays2", System.Data.SqlDbType.Int).Value = NumberDays;
                    NumberDesactiveDonors = (int)Cmd.ExecuteScalar();
                    // Total regulier number
                    Cmd.CommandText = "select count(*) from donors where donor_type = 'Régulier'" +
                        "and YEAR(donation_date) = YEAR(GETDATE()) and DATEDIFF(DAY, donation_date, GETDATE()) <= @NumberDays3";
                    Cmd.Parameters.Add("@NumberDays3", System.Data.SqlDbType.Int).Value = NumberDays;
                    Number_reg = (int)Cmd.ExecuteScalar();
                    // Total regulier cp number
                    Cmd.CommandText = "select count(*) from donors where donor_type = 'Régulier-Cp'" +
                        "and YEAR(donation_date) = YEAR(GETDATE()) and DATEDIFF(DAY, donation_date, GETDATE()) <= @NumberDays4";
                    Cmd.Parameters.Add("@NumberDays4", System.Data.SqlDbType.Int).Value = NumberDays;
                    Number_reg_cp = (int)Cmd.ExecuteScalar();
                    // Total occasionnel number
                    Cmd.CommandText = "select count(*) from donors where donor_type = 'Occasionnel'" +
                        "and YEAR(donation_date) = YEAR(GETDATE()) and DATEDIFF(DAY, donation_date, GETDATE()) <= @NumberDays5";
                    Cmd.Parameters.Add("@NumberDays5", System.Data.SqlDbType.Int).Value = NumberDays;
                    Number_occ = (int)Cmd.ExecuteScalar();
                    // Total occasionnel cp number
                    Cmd.CommandText = "select count(*) from donors where donor_type = 'Occasionnel-Cp'" +
                        "and YEAR(donation_date) = YEAR(GETDATE()) and DATEDIFF(DAY, donation_date, GETDATE()) <= @NumberDays6";
                    Cmd.Parameters.Add("@NumberDays6", System.Data.SqlDbType.Int).Value = NumberDays;
                    Number_occ_cp = (int)Cmd.ExecuteScalar();
                }

            }
        }

        private void CandidatsAnalysis()
        {
            CandidatsList = new List<StatsByDate>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Cmd = new SqlCommand())
                {
                    Cmd.Connection = connection;
                    // List for candidats chart
                    Cmd.CommandText = "select donation_date,count(*) as alldonors from donors" +
                                      " where DATEDIFF(DAY, donation_date, GETDATE()) <= @NumberDays" +
                                      " and YEAR(donation_date) = YEAR(GETDATE()) group by donation_date  ";
                    Cmd.Parameters.Add("@NumberDays", System.Data.SqlDbType.Int).Value = NumberDays;


                    var Reader = Cmd.ExecuteReader();
                    var ResulTable = new List<KeyValuePair<DateTime, int>>();
                    while (Reader.Read())
                    {
                        ResulTable.Add(new KeyValuePair<DateTime, int>((DateTime)Reader[0], (int)Reader[1]));
                    }
                    Reader.Close();

                    if (NumberDays<=30)
                    {

                        foreach (var item in ResulTable)
                        {
                            CandidatsList.Add(new StatsByDate()
                            {
                                Date = item.Key.ToString("dd MMM"),
                                Total = item.Value
                            });
                        }
                    }
                    else if (NumberDays<=92)
                    {

                        CandidatsList = (from alldonors in ResulTable
                                         group alldonors by alldonors.Key.ToString("MMM")
                                         into donor
                                         select new StatsByDate
                                         {
                                             Date = donor.Key,
                                             Total = donor.Sum(counter => counter.Value)
                                         }
                                         ).ToList();
                    }
                    else
                    {
                        CandidatsList = (from alldonors in ResulTable
                                         group alldonors by alldonors.Key.ToString("MMM")
                                          into donor
                                         select new StatsByDate
                                         {
                                             Date = donor.Key,
                                             Total = donor.Sum(counter => counter.Value)
                                         }
                                          ).ToList();
                    }

                }

            }
        }


        private void MagazinAnalysis()
        {
            MagazinSangList = new List<KeyValuePair<string, int>>();
            ActiveDonorList = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Cmd = new SqlCommand())
                {
                    Cmd.Connection = connection;
                    // List for candidats chart
                    Cmd.CommandText = "select donor_group as groupage,count(donor_group) as stock from donors" +
                        " where DATEDIFF(DAY, donation_date, GETDATE()) <= @NumberDays" +
                        " and YEAR(donation_date) = YEAR(GETDATE()) and donor_poche = 'Poche'" +
                        " group by donor_group order by groupage";
                    Cmd.Parameters.Add("@NumberDays", System.Data.SqlDbType.Int).Value = NumberDays;


                    var Reader = Cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        MagazinSangList.Add(new KeyValuePair<string, int>((string)Reader[0], (int)Reader[1]));
                    }
                    Reader.Close();


                }

            }
        }

        // public methods
        public void LoadData(int NumberDays)
        {
            this.NumberDays = NumberDays;   

            GetNumbers();
            CandidatsAnalysis();
            MagazinAnalysis();
        }

    }
}
*/