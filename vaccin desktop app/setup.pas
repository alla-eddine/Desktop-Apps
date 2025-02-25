unit setup;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.ExtDlgs, Vcl.StdCtrls,inifiles,
  Vcl.ExtCtrls, Vcl.Buttons;

type
  TForm18 = class(TForm)
    Dialog1: TSaveTextFileDialog;
    GroupBox1: TGroupBox;
    Label1: TLabel;
    Edit1: TEdit;
    SpeedButton3: TSpeedButton;
    SpeedButton2: TSpeedButton;
    SpeedButton1: TSpeedButton;
    procedure SpeedButton3Click(Sender: TObject);
    procedure SpeedButton1Click(Sender: TObject);
    procedure SpeedButton2Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form18: TForm18;

implementation
    uses mdata,main;
{$R *.dfm}



procedure TForm18.SpeedButton1Click(Sender: TObject);
begin
Close;
end;

procedure TForm18.SpeedButton2Click(Sender: TObject);
var save:Tinifile;
begin
try
 mdata.data.ADOConnection1.Close;
 mdata.data.ADOConnection1.ConnectionString:='Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source ='+edit1.text+';Persist Security Info=False;';
 mdata.data.ADOConnection1.Open;
 if createdir('C:/data')  then
   begin
   save:=Tinifile.Create('C:\data\save.ini');
   save.WriteString('save','edit',edit1.text);
   end
 else
  begin
   save:=Tinifile.Create('C:\data\save.ini');
   save.WriteString('save','edit',edit1.text);
  end;
 showmessage(' „ «·≈ ’«· »‰Ã«Õ');
  mdata.data.child.active:=true;
  mdata.data.stat.active:=true;
  mdata.data.stat1.active:=true;
  mdata.data.stat2.active:=true;
  mdata.data.stat3.active:=true;
  mdata.data.stat4.active:=true;
  mdata.data.stat5.active:=true;
  mdata.data.stat6.active:=true;
  mdata.data.stat7.active:=true;
  mdata.data.stat8.active:=true;
  mdata.data.stat9.active:=true;
  mdata.data.stat10.active:=true;
  mdata.data.stat11.active:=true;
  mdata.data.stat12.active:=true;
 Close;
except
  showmessage('ÕœÀ Œÿ« √À‰«¡ «·≈ ’«·');
  Close;
end;
end;

procedure TForm18.SpeedButton3Click(Sender: TObject);
begin
 if Dialog1.Execute then
begin
 edit1.Text:=Dialog1.FileName;
end;
end;
end.
