unit salle;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Data.DB, Vcl.StdCtrls, Vcl.Grids,
  Vcl.DBGrids, Vcl.Buttons;

type
  TForm14 = class(TForm)
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
  Form14: TForm14;

implementation
  uses mdata,addsalle;
{$R *.dfm}





procedure TForm14.SpeedButton1Click(Sender: TObject);
begin
 form15.Show;
end;

procedure TForm14.SpeedButton2Click(Sender: TObject);
begin
mdata.data.salles.Delete;
showmessage('�� ����� �����');
end;

procedure TForm14.SpeedButton3Click(Sender: TObject);
begin
close;
end;

end.
