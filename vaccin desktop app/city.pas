unit city;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Data.DB, Vcl.StdCtrls, Vcl.Grids,
  Vcl.DBGrids, Vcl.Buttons;

type
  TForm13 = class(TForm)
    GroupBox1: TGroupBox;
    Label1: TLabel;
    DBGrid1: TDBGrid;
    GroupBox2: TGroupBox;
    SpeedButton1: TSpeedButton;
    SpeedButton2: TSpeedButton;
    SpeedButton3: TSpeedButton;
    procedure SpeedButton1Click(Sender: TObject);
    procedure SpeedButton2Click(Sender: TObject);
    procedure SpeedButton3Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form13: TForm13;

implementation
 uses mdata,addcity;
{$R *.dfm}





procedure TForm13.SpeedButton1Click(Sender: TObject);
begin
form12.Show;
end;

procedure TForm13.SpeedButton2Click(Sender: TObject);
begin
mdata.data.street.Delete;
showmessage('�� ����� �����');
end;

procedure TForm13.SpeedButton3Click(Sender: TObject);
begin
close;
end;

end.













