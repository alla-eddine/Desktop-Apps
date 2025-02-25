unit addcity;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.Buttons;

type
  TForm12 = class(TForm)
    GroupBox1: TGroupBox;
    Edit1: TEdit;
    Label1: TLabel;
    SpeedButton1: TSpeedButton;
    procedure SpeedButton1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form12: TForm12;

implementation
  uses mdata,main;
{$R *.dfm}




procedure TForm12.SpeedButton1Click(Sender: TObject);
begin
   mdata.data.street.Insert;
   mdata.data.streetstreet_name.text:=edit1.Text;
   mdata.data.street.Post;
   showmessage('  „ «· Œ“Ì‰ »‰Ã«Õ ');
   close;
end;

end.
