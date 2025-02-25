unit savedb;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.ExtCtrls, Vcl.ExtDlgs,
  Vcl.Buttons;

type
  TForm20 = class(TForm)
    SaveDialog1: TSaveDialog;
    GroupBox1: TGroupBox;
    Label1: TLabel;
    Edit1: TEdit;
    SpeedButton3: TSpeedButton;
    SpeedButton1: TSpeedButton;
    SpeedButton2: TSpeedButton;
    procedure SpeedButton1Click(Sender: TObject);
    procedure SpeedButton2Click(Sender: TObject);
    procedure SpeedButton3Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form20: TForm20;

implementation

{$R *.dfm}

procedure TForm20.SpeedButton1Click(Sender: TObject);
begin
try
CopyFile(Pchar(ChangeFileExt(Application.ExeName,'.mdb')),Pchar(edit1.Text+'.mdb'),false);
showmessage('  „ «·Õ›Ÿ »‰Ã«Õ ');
close;
except
showmessage(' ÕœÀ Œÿ√ √À‰«¡ Õ›Ÿ ﬁ«⁄œ… «·»Ì«‰«  ');
end;
end;

procedure TForm20.SpeedButton2Click(Sender: TObject);
begin
Close;
end;

procedure TForm20.SpeedButton3Click(Sender: TObject);
begin
if SaveDialog1.Execute then
begin
 edit1.Text:=SaveDialog1.FileName;
end;
end;

end.
