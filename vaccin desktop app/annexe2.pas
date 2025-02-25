unit annexe2;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls,Dateutils, frxClass, frxDBSet,
  Vcl.Buttons;

type
  TForm11 = class(TForm)
    GroupBox1: TGroupBox;
    annexe2: TfrxReport;
    frxDBDataset4: TfrxDBDataset;
    ComboBox2: TComboBox;
    ComboBox3: TComboBox;
    Label2: TLabel;
    Label3: TLabel;
    SpeedButton1: TSpeedButton;
    procedure FormShow(Sender: TObject);
    procedure SpeedButton1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form11: TForm11;

implementation
  uses mdata,main;
{$R *.dfm}



procedure TForm11.FormShow(Sender: TObject);
begin
mdata.data.child.Refresh;
mdata.data.years.Close;
mdata.data.years.open;
mdata.data.years.first;
combobox3.Clear;
while not mdata.data.years.eof do
begin
  combobox3.Items.Append(mdata.data.years.FieldByName('years').value);
  mdata.data.years.Next;
end;
end;

procedure TForm11.SpeedButton1Click(Sender: TObject);
begin
with mdata.data.annexe2 do
  begin
    active:=false;
    sql.clear;
    sql.add('select * from child');
    sql.add('WHERE year(child_birth) =' +Quotedstr(combobox3.Text));
    sql.add('and Month(child_birth) =' +inttostr(combobox2.ItemIndex+1));
    sql.Add('and child_place=''·«''');
    sql.add('order by child_cn');
    execsql;
    active:=true;
  end;
annexe2.ShowReport();
Close;
end;
end.
