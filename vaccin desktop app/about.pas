unit about;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.Imaging.pngimage,
  Vcl.ExtCtrls,System.UITypes;

type
  TForm24 = class(TForm)
    GroupBox1: TGroupBox;
    Label1: TLabel;
    Image1: TImage;
    Image2: TImage;
    Label2: TLabel;
    Label3: TLabel;
    procedure Label2MouseEnter(Sender: TObject);
    procedure Label2MouseLeave(Sender: TObject);
    procedure FormShow(Sender: TObject);
    procedure Label2Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form24: TForm24;

implementation
   uses ShellAPI;
{$R *.dfm}





procedure TForm24.FormShow(Sender: TObject);
begin
label2.Font.Color:=clblue;
end;

procedure TForm24.Label2Click(Sender: TObject);
begin
ShellExecute(0,'OPEN',PChar(label2.Caption),'','',SW_SHOWNORMAL);
end;

procedure TForm24.Label2MouseEnter(Sender: TObject);
begin
label2.Font.Style := label2.Font.Style + [FsUnderline];
end;

procedure TForm24.Label2MouseLeave(Sender: TObject);
begin
label2.Font.Style := label2.Font.Style - [FsUnderline];
end;

end.
