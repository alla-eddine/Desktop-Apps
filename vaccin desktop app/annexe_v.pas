unit annexe_v;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, frxClass, frxDBSet,DateUtils,
  Vcl.Buttons;

type
  TForm19 = class(TForm)
    GroupBox1: TGroupBox;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    ComboBox1: TComboBox;
    ComboBox2: TComboBox;
    ComboBox3: TComboBox;
    annexe_v: TfrxReport;
    frxDBDataset1: TfrxDBDataset;
    SpeedButton1: TSpeedButton;
    procedure FormShow(Sender: TObject);
    procedure SpeedButton1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form19: TForm19;

implementation
  uses mdata;
{$R *.dfm}


procedure TForm19.FormShow(Sender: TObject);
begin
mdata.data.child.Refresh;
mdata.data.years.Close;
mdata.data.years.open;
mdata.data.years.first;
combobox2.Clear;
while not mdata.data.years.eof do
begin
  combobox2.Items.Append(mdata.data.years.FieldByName('years').value);
  mdata.data.years.Next;
end;
mdata.data.street.Close;
mdata.data.street.open;
mdata.data.street.first;
combobox1.Clear;
while not mdata.data.street.eof do
begin
  combobox1.Items.Append(mdata.data.street.FieldByName('street_name').value);
  mdata.data.street.Next;
end;
end;

procedure TForm19.SpeedButton1Click(Sender: TObject);
var
  Memo,Memo1,Memo2: TfrxMemoView;
  i:integer;
  Component,Component1,Component2: TfrxComponent;
begin
with mdata.data.annexe_v do
begin
  active:=false;
  sql.clear;
  sql.add('select * from child');
  sql.add('WHERE child_year = ' +QuotedStr(ComboBox2.Text));
  sql.add('and child_adress like ' +QuotedStr('%'+ComboBox1.Text+'%'));
  sql.add('AND Month(child_birth) =' +inttostr(combobox3.ItemIndex+1));
  sql.Add('and child_place=''���''');
  sql.add('order by child_cn');
  execsql;
  active:=true;
end;
//------------------------------------------------------------------------------

//--------------------- vaccin table -------------------------------------------
i:=1;
Component := annexe_v.FindObject('salle');
Memo := Component as TfrxMemoView;
Memo.Text := combobox1.Text;
with mdata.data.vaccin do
begin
  active:=false;
  sql.Clear;
  sql.Add('select * from vaccin');
  sql.Add('where vaccin_month Is Not Null ');
  active:=true;
end;
mdata.data.vaccin.First;
while not mdata.data.vaccin.Eof do
 begin
  Component2 := annexe_v.FindObject('v'+inttostr(i));
  Memo2 := Component2 as TfrxMemoView;
  Memo2.Text := mdata.data.vaccinvaccin_name.Text;
  Memo2.Font.Size:=7;
  Memo2.HAlign:=haCenter;
  mdata.data.vaccin.Next;
  i:=i+1;
 end;

i:=1;
with mdata.data.vaccin do
begin
  active:=false;
  sql.Clear;
  sql.Add('select * from vaccin');
  sql.Add('where vaccin_month Is Null ');
  active:=true;
end;
mdata.data.vaccin.First;
while not mdata.data.vaccin.Eof do
 begin
  Component := annexe_v.FindObject('m'+inttostr(i));
  Component1 := annexe_v.FindObject('n'+inttostr(i));
  Memo := Component as TfrxMemoView;
  Memo1 := Component1 as TfrxMemoView;
  Memo.Text := mdata.data.vaccinvaccin_name.Text;
  Memo1.Text := mdata.data.vaccinvaccin_lot.Text;
  Memo.HAlign:=haCenter;
  Memo1.HAlign:=haCenter;
  Memo.Font.Size:=8;
  Memo1.Font.Size:=8;
  mdata.data.vaccin.Next;
  i:=i+1;
 end;

annexe_v.ShowReport();
Close;
end;

//------------------------------------------------------------------------------

end.
