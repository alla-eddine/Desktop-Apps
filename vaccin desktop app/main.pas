unit main;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Data.DB, Vcl.Grids,
  Vcl.DBGrids, Vcl.Menus, frxClass, frxDBSet,DateUtils, Vcl.Imaging.jpeg,
  Vcl.ExtCtrls, Vcl.Buttons;

type
  TForm2 = class(TForm)
    GroupBox1: TGroupBox;
    GroupBox3: TGroupBox;
    GroupBox4: TGroupBox;
    GroupBox5: TGroupBox;
    Edit1: TEdit;
    Edit2: TEdit;
    GroupBox6: TGroupBox;
    GroupBox7: TGroupBox;
    ComboBox1: TComboBox;
    ComboBox2: TComboBox;
    ComboBox3: TComboBox;
    GroupBox8: TGroupBox;
    Label2: TLabel;
    DBGrid1: TDBGrid;
    GroupBox9: TGroupBox;
    DBGrid2: TDBGrid;
    GroupBox10: TGroupBox;
    GroupBox11: TGroupBox;
    ci: TfrxReport;
    frxDBDataset2: TfrxDBDataset;
    frxDBDataset3: TfrxDBDataset;
    con: TfrxReport;
    Image1: TImage;
    MainMenu1: TMainMenu;
    N1: TMenuItem;
    N2: TMenuItem;
    N3: TMenuItem;
    N4: TMenuItem;
    N5: TMenuItem;
    N6: TMenuItem;
    N7: TMenuItem;
    N8: TMenuItem;
    annexe21: TMenuItem;
    annexe31: TMenuItem;
    fichedelaliasion1: TMenuItem;
    N9: TMenuItem;
    annexe51: TMenuItem;
    annexe5: TfrxReport;
    stat: TfrxDBDataset;
    annexe6: TfrxReport;
    stat2: TfrxDBDataset;
    annexe61: TMenuItem;
    stat1: TfrxDBDataset;
    stat5: TfrxDBDataset;
    stat4: TfrxDBDataset;
    stat3: TfrxDBDataset;
    stat6: TfrxDBDataset;
    stat7: TfrxDBDataset;
    stat8: TfrxDBDataset;
    stat9: TfrxDBDataset;
    stat10: TfrxDBDataset;
    stat11: TfrxDBDataset;
    stat12: TfrxDBDataset;
    N10: TMenuItem;
    N11: TMenuItem;
    annexev1: TMenuItem;
    N12: TMenuItem;
    SpeedButton1: TSpeedButton;
    SpeedButton2: TSpeedButton;
    SpeedButton3: TSpeedButton;
    SpeedButton4: TSpeedButton;
    SpeedButton5: TSpeedButton;
    SpeedButton6: TSpeedButton;
    SpeedButton7: TSpeedButton;
    SpeedButton8: TSpeedButton;
    SpeedButton9: TSpeedButton;
    SpeedButton10: TSpeedButton;
    SpeedButton11: TSpeedButton;
    SpeedButton12: TSpeedButton;
    SpeedButton13: TSpeedButton;
    SpeedButton14: TSpeedButton;
    N13: TMenuItem;
    N14: TMenuItem;
    N15: TMenuItem;
    Label1: TLabel;
    nm: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    procedure DBGrid1CellClick(Column: TColumn);
    procedure FormShow(Sender: TObject);
    procedure DBGrid2CellClick(Column: TColumn);
    procedure Edit1Change(Sender: TObject);
    procedure Edit2Change(Sender: TObject);
    procedure ComboBox1Change(Sender: TObject);
    procedure ComboBox2Change(Sender: TObject);
    procedure ComboBox3Change(Sender: TObject);
    procedure Button8Click(Sender: TObject);
    procedure Button16Click(Sender: TObject);
    procedure Button15Click(Sender: TObject);
    procedure N2Click(Sender: TObject);
    procedure N3Click(Sender: TObject);
    procedure N4Click(Sender: TObject);
    procedure N5Click(Sender: TObject);
    procedure N7Click(Sender: TObject);
    procedure N8Click(Sender: TObject);
    procedure annexe31Click(Sender: TObject);
    procedure annexe21Click(Sender: TObject);
    procedure annexe51Click(Sender: TObject);
    procedure annexe61Click(Sender: TObject);
    procedure N11Click(Sender: TObject);
    procedure annexev1Click(Sender: TObject);
    procedure N12Click(Sender: TObject);
    procedure SpeedButton1Click(Sender: TObject);
    procedure SpeedButton2Click(Sender: TObject);
    procedure SpeedButton3Click(Sender: TObject);
    procedure SpeedButton4Click(Sender: TObject);
    procedure SpeedButton5Click(Sender: TObject);
    procedure SpeedButton6Click(Sender: TObject);
    procedure SpeedButton7Click(Sender: TObject);
    procedure SpeedButton8Click(Sender: TObject);
    procedure SpeedButton9Click(Sender: TObject);
    procedure SpeedButton10Click(Sender: TObject);
    procedure SpeedButton11Click(Sender: TObject);
    procedure SpeedButton12Click(Sender: TObject);
    procedure SpeedButton13Click(Sender: TObject);
    procedure SpeedButton14Click(Sender: TObject);
    procedure N13Click(Sender: TObject);
    procedure N14Click(Sender: TObject);
    procedure fichedelaliasion1Click(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
    procedure N15Click(Sender: TObject);



  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form2: TForm2;

implementation
  uses mdata,addchild,editchild,addvaccin,addinj,savedb,savedbv,changepass,about
  ,editvaccin,annexe3,annexe2,death,city,salle,stat,stat2,setup,annexe_v,fiche;
{$R *.dfm}

procedure TForm2.annexe21Click(Sender: TObject);
begin
form11.Show;
end;

procedure TForm2.annexe31Click(Sender: TObject);
begin
form9.Show;
end;


procedure TForm2.annexe51Click(Sender: TObject);
begin
form16.Show;
end;

procedure TForm2.annexe61Click(Sender: TObject);
begin
form17.show;
end;

procedure TForm2.annexev1Click(Sender: TObject);
begin
form19.Show;
end;

//-------------------------------fichedelaliasion-------------------------------



//--------------------------------cetificat report------------------------------







procedure TForm2.Button16Click(Sender: TObject);
begin
form16.Show;
end;

procedure TForm2.Button15Click(Sender: TObject);
begin
form14.Show;
end;




//-------------------------- delete child  -------------------------------------

//------------------------------------------------------------------------------





//-------------------------- delete injection  ---------------------------------

//-------------------------- end of delete injection  --------------------------


//------------------------------- annexe2  -------------------------------------
procedure TForm2.Button8Click(Sender: TObject);
begin
form11.Show;
end;
//------------------------------- end annexe2  ---------------------------------

//-------------------------- years filter  -------------------------------------
procedure TForm2.ComboBox1Change(Sender: TObject);
var val:string;
begin
val :=QuotedStr('%'+ComboBox1.Text+'%');
  if (combobox1.Text = '����') or (combobox1.Text = '') then
  mdata.data.child.Filtered:= false
  else
  begin
  mdata.data.child.Filter:= ' child_year '  + ' LIKE ' + val ;
  mdata.data.child.Filtered:=true;
  end;
  label4.Caption:=' �� :  '+inttostr(mdata.data.child.recordcount);
  if (combobox1.ItemIndex = 0) or (combobox1.ItemIndex = -1) then
    label5.Caption:='���� �������'
  else
    label5.Caption:=' ��� '+combobox1.Text;
end;
//-------------------------- end of years filter  ------------------------------


//-------------------------- place filter  -------------------------------------
procedure TForm2.ComboBox2Change(Sender: TObject);
var val:string;
begin
  if ((combobox2.Text = '����') or (combobox2.Text = ''))
  and ((combobox1.Text = '����') or (combobox1.Text = '')) then
  mdata.data.child.Filtered:= false
  else
  begin
  if (combobox2.Text = '���� �������') then
   begin
    if (combobox1.Text = '����') or (combobox1.Text = '') then
     begin
      val:='���';
      mdata.data.child.Filter:= ' child_place LIKE '+QuotedStr(val);
      mdata.data.child.Filtered:=true;
      end
      else
      begin
      val:='���';
      mdata.data.child.Filter:= ' child_place LIKE '+QuotedStr(val)+' and child_year = '+combobox1.Text ;
      mdata.data.child.Filtered:=true;
      end;
   end
  else
  begin
    if (combobox1.Text = '����') or (combobox1.Text = '') then
     begin
      val:='��';
      mdata.data.child.Filter:= ' child_place LIKE '+QuotedStr(val);
      mdata.data.child.Filtered:=true;
      end
      else
      begin
      val:='��';
      mdata.data.child.Filter:= ' child_place LIKE '+QuotedStr(val)+' and child_year = '+combobox1.Text ;
      mdata.data.child.Filtered:=true;
      end;
  end;
  end;
end;


//-------------------------- end of place  filter  -----------------------------


//-------------------------- adress  filter  -----------------------------------
procedure TForm2.ComboBox3Change(Sender: TObject);
var val,val2:string ;
begin
val:=combobox3.Text;
val2:=combobox1.Text;
if (val<>'')  then
begin
  if (val2='') or (val2='����') then
    begin
    mdata.data.child.Filter:= ' child_adress LIKE '+QuotedStr(val + '*');
    mdata.data.child.Filtered:=true;
    end
  else
    begin
    mdata.data.child.Filter:= ' child_adress LIKE '+QuotedStr(val + '*')+' and child_year = '+combobox1.Text ;
    mdata.data.child.Filtered:=true;
    end;
end
else
  mdata.data.child.Filtered:=false;
end;

//-------------------------- end of adress  filter -----------------------------


//-------------------------- db grid1 click  -----------------------------------
procedure TForm2.DBGrid1CellClick(Column: TColumn);
begin
  mdata.data.child.Open;
  if mdata.data.child.RecordCount > 0 then
  begin
  form4.Edit1.Text:=inttostr(mdata.data.childchild_cn.Value);
  form4.Edit2.Text:=mdata.data.childchild_fn.Value;
  form4.Edit3.Text:=mdata.data.childchild_Ln.Value;
  label1.Visible:=true;
  nm.Caption:=mdata.data.childfullname.Text;
  nm.Color:=clred;
  if mdata.data.childchild_birth.text <> '' then
    begin
      form4.DateTimePicker1.Date:=mdata.data.childchild_birth.Value;
    end;
  form4.ComboBox1.Text:=mdata.data.childchild_city.Value;
  form4.ComboBox2.Text:=mdata.data.childchild_born.Value;
  form4.ComboBox3.Text:=mdata.data.childchild_place.Value;
  form4.Edit4.Text:=mdata.data.childchild_f.Value;
  form4.Edit6.Text:=mdata.data.childchild_adress.Value;
   if (mdata.data.childchild_status.Text = '���') then
     form10.DateTimePicker1.Date:=now
   else
     form10.DateTimePicker1.Date:=strtodate(mdata.data.childchild_death.text);
  form10.ComboBox1.Text:=mdata.data.childchild_status.Text;
with mdata.data.injection do
  begin
    active:=false;
    sql.Clear;
    sql.Add('select * from injection ');
    sql.Add('where child_idi = '+mdata.data.childchild_id.Text);
    sql.Add('order by (vaccin_no)');
    execsql;
    active:=true;
  end;
  end;
end;
//-------------------------- end of db grid1 click  -----------------------------


//-------------------------- db grid2 click  ----------------------------
procedure TForm2.DBGrid2CellClick(Column: TColumn);
begin
form8.combobox1.Text:=mdata.data.injectionvaccin_state.Text;
form8.combobox2.Text:=mdata.data.injectionvaccin_place.Text;
form8.Edit1.Text:=mdata.data.injectionvaccin_no.Text;
if (mdata.data.injectioninjection_date.Text <> '/') and
   (mdata.data.injectioninjection_date.Text <> '') then
begin
form8.DateTimePicker1.Date:=strtodate(mdata.data.injectioninjection_date.Text);
end;
end;
//-------------------------- end of db grid2 click  ----------------------------


//-------------------------- fullname filter  ----------------------------------
procedure TForm2.Edit1Change(Sender: TObject);
var s,val:string;
begin
if Edit1.text<>'' then
begin
val :=QuotedStr( '%'+Edit1.Text+'%');
s:='fullname like ' + val;
mdata.data.child.filter:=s;
mdata.data.child.filtered:=true;
end
else
mdata.data.child.filtered:=false;
end;
//-------------------------- end of fullname filter ----------------------------

//-------------------------- child_cn filter -----------------------------------
procedure TForm2.Edit2Change(Sender: TObject);
var val,val2:string ;
begin
val:=edit2.Text;
val2:=combobox1.Text;
if (Edit2.text<>'')  then
begin
  if (val2='') or (val2='����') then
    begin
    mdata.data.child.Filter:= ' child_cn LIKE '+QuotedStr(val);
    mdata.data.child.Filtered:=true;
    end
  else
    begin
    mdata.data.child.Filter:= ' child_cn LIKE '+QuotedStr(val)+' and child_year = '+combobox1.Text ;
    mdata.data.child.Filtered:=true;
    end;
end
else
  mdata.data.child.Filtered:=false;
end;

procedure TForm2.fichedelaliasion1Click(Sender: TObject);
begin
form23.Show;
end;

//-------------------------- end of child_cn filter ----------------------------

procedure TForm2.FormClose(Sender: TObject; var Action: TCloseAction);
begin
application.Terminate;
end;

procedure TForm2.FormShow(Sender: TObject);
begin

mdata.data.child.Close;
mdata.data.child.Open;
mdata.data.child.Refresh;
label4.Caption:=' �� :  '+inttostr(mdata.data.child.recordcount);
combobox1.Clear;
mdata.data.years.Close;
mdata.data.years.open;
mdata.data.years.first;
while not mdata.data.years.eof do
begin
  combobox1.Items.Append(mdata.data.years.FieldByName('years').value);
  mdata.data.years.Next;
end;


combobox3.Clear;
mdata.data.street.Close;
mdata.data.street.open;
mdata.data.street.first;
while not mdata.data.street.eof do
begin
  combobox3.Items.Append(mdata.data.streetstreet_name.value);
  mdata.data.street.Next;
end;


end;











procedure TForm2.N11Click(Sender: TObject);
begin
form18.show;
end;

procedure TForm2.N12Click(Sender: TObject);
begin
form20.Show;
end;

procedure TForm2.N13Click(Sender: TObject);
begin
form21.Show;
end;

procedure TForm2.N14Click(Sender: TObject);
begin
form22.show;
end;

procedure TForm2.N15Click(Sender: TObject);
begin
form24.show;
end;

procedure TForm2.N2Click(Sender: TObject);
begin
addchild.Form3.Show;
end;

procedure TForm2.N3Click(Sender: TObject);
begin
form6.Show;
end;

procedure TForm2.N4Click(Sender: TObject);
begin
form14.Show;
end;

procedure TForm2.N5Click(Sender: TObject);
begin
form13.Show;
end;

procedure TForm2.N7Click(Sender: TObject);
begin
with mdata.data.injection do
  begin
    active:=false;
    sql.Clear;
    sql.Add('select * from injection');
    sql.Add('where injection.child_idi =' +mdata.data.child.FieldByName('child_id').Text );
    ExecSQL;
    active:=true;
  end;

ci.ShowReport();
end;

procedure TForm2.N8Click(Sender: TObject);
begin
con.ShowReport();
end;

procedure TForm2.SpeedButton10Click(Sender: TObject);
begin
form9.show;
end;

procedure TForm2.SpeedButton11Click(Sender: TObject);
begin
form23.Show;
end;
procedure TForm2.SpeedButton12Click(Sender: TObject);
begin
with mdata.data.injection do
  begin
    active:=false;
    sql.Clear;
    sql.Add('select * from injection');
    sql.Add('where injection.child_idi =' +mdata.data.child.FieldByName('child_id').Text );
    ExecSQL;
    active:=true;
  end;

ci.ShowReport();
end;
procedure TForm2.SpeedButton13Click(Sender: TObject);
begin
con.ShowReport();
end;

procedure TForm2.SpeedButton14Click(Sender: TObject);
begin
form19.Show;
end;

//----------------------end of cetificat report --------------------------------


//-----------------------------end fichedelaliasion-----------------------------

procedure TForm2.SpeedButton1Click(Sender: TObject);
begin
form3.show;
end;

procedure TForm2.SpeedButton2Click(Sender: TObject);
begin
form4.Show;
end;
procedure TForm2.SpeedButton3Click(Sender: TObject);
begin
with mdata.data.injection do
  begin
    sql.Clear;
    sql.Add('delete * from injection ');
    sql.Add('where child_idi = '+mdata.data.childchild_id.Text);
    execsql;
  end;
mdata.data.child.Delete;
showmessage('�� ��� ������� �����');
end;

procedure TForm2.SpeedButton4Click(Sender: TObject);
begin
form10.Show;
end;

procedure TForm2.SpeedButton5Click(Sender: TObject);
begin
form5.Show;
end;

procedure TForm2.SpeedButton6Click(Sender: TObject);
begin
form8.Show;
end;
procedure TForm2.SpeedButton7Click(Sender: TObject);
begin
mdata.data.child.Edit;
mdata.data.child.Fields[mdata.data.injectionvaccin_no.Value+19].Clear;
mdata.data.child.Post;
mdata.data.injection.Delete;
mdata.data.injection.Close;
mdata.data.injection.Open;
with mdata.data.injection do
  begin
    active:=false;
    sql.Clear;
    sql.Add('select * from injection ');
    sql.Add('where child_idi = '+mdata.data.childchild_id.Text);
    sql.Add('and vaccin_state = ''���''' );
    sql.Add('order by injection_date ');
    execsql;
    active:=true;
  end;
mdata.data.injection.Last;

if mdata.data.injection.RecordCount > 0 then
 begin
  mdata.data.child.Edit;
  mdata.data.childchild_salle.Text:=mdata.data.injectionvaccin_place.Text;
  mdata.data.childvaccin_m.Value:= mdata.data.injection['vm'];
  mdata.data.childvaccin_y.Value:= mdata.data.injection['vy'];
  mdata.data.child.Post;
 end
 else
 begin
  mdata.data.child.Edit;
  mdata.data.childchild_salle.Clear;
  mdata.data.childvaccin_m.Clear;
  mdata.data.childvaccin_y.Clear;
  mdata.data.child.Post;
  end;
  with mdata.data.injection do
    begin
      active:=false;
      sql.Clear;
      sql.Add('select * from injection ');
      sql.Add('where child_idi = '+mdata.data.childchild_id.Text);
      sql.Add('order by vaccin_no ');
      execsql;
      active:=true;
    end;
showmessage('�� ����� �����');
end;

procedure TForm2.SpeedButton8Click(Sender: TObject);
begin
form6.Show;
end;

procedure TForm2.SpeedButton9Click(Sender: TObject);
begin
form11.Show;
end;

end.
