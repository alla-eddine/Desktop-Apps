unit savedbv;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.Buttons;

type
  TForm21 = class(TForm)
    SaveDialog1: TSaveDialog;
    GroupBox1: TGroupBox;
    Label1: TLabel;
    Edit1: TEdit;
    SpeedButton3: TSpeedButton;
    SpeedButton1: TSpeedButton;
    SpeedButton2: TSpeedButton;
    procedure SpeedButton1Click(Sender: TObject);
    procedure SpeedButton3Click(Sender: TObject);
    procedure SpeedButton2Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form21: TForm21;

implementation

{$R *.dfm}

procedure TForm21.SpeedButton1Click(Sender: TObject);
begin
try
CopyFile(Pchar(ChangeFileExt('vaccin_vide','.mdb')),Pchar(edit1.Text+'.mdb'),false);
showmessage(' �� ����� ����� ');
close;
except
showmessage(' ��� ��� ����� ��� ����� �������� ');
end;
end;

procedure TForm21.SpeedButton2Click(Sender: TObject);
begin
close;
end;

procedure TForm21.SpeedButton3Click(Sender: TObject);
begin
if SaveDialog1.Execute then
begin
 edit1.Text:=SaveDialog1.FileName;
end;
end;

end.
