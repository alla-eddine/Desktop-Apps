unit addsalle;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.Buttons;

type
  TForm15 = class(TForm)
    GroupBox1: TGroupBox;
    Label1: TLabel;
    Edit1: TEdit;
    SpeedButton1: TSpeedButton;
    procedure SpeedButton1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form15: TForm15;

implementation
  uses mdata;
{$R *.dfm}



procedure TForm15.SpeedButton1Click(Sender: TObject);
begin
   mdata.data.salles.Insert;
   mdata.data.sallessalle_name.Text:=edit1.Text;
   mdata.data.salles.Post;
   showmessage(' �� ������� ����� ');
   close;
end;

end.
