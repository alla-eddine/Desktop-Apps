unit fiche;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.Buttons,frxClass, frxDBSet,DateUtils;

type
  TForm23 = class(TForm)
    GroupBox1: TGroupBox;
    ComboBox2: TComboBox;
    Label2: TLabel;
    SpeedButton1: TSpeedButton;
    fiche: TfrxReport;
    frxDBDataset1: TfrxDBDataset;
    procedure SpeedButton1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form23: TForm23;

implementation
  uses mdata,main;
{$R *.dfm}

procedure TForm23.SpeedButton1Click(Sender: TObject);
var
  Memo,Memo1,Memo2: TfrxMemoView;
  i:integer;
  v:string;
  Component,Component1,Component2: TfrxComponent;
begin
mdata.data.child.Refresh;
v:='��';
with mdata.data.fiche do
  begin
    active:=false;
    sql.clear;
    sql.add('select * from child');
    sql.add('WHERE child_place = ' +QuotedStr(v));
    sql.Add('and vaccin_m = ' +inttostr(combobox2.ItemIndex+1));
    sql.Add('and Datediff("m",now(),child_birth) >= ''2'' ' );
    sql.add('order by child_cn');
    execsql;
    active:=true;
  end;

i:=1;
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
  Component2 := fiche.FindObject('v'+inttostr(i));
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
  Component := fiche.FindObject('m'+inttostr(i));
  Component1 := fiche.FindObject('n'+inttostr(i));
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
fiche.ShowReport();
Close;
end;

end.
