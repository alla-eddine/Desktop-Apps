unit addvaccin;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Data.DB, Vcl.StdCtrls, Vcl.Grids,
  Vcl.DBGrids, Vcl.Buttons;

type
  TForm6 = class(TForm)
    GroupBox1: TGroupBox;
    GroupBox2: TGroupBox;
    Label1: TLabel;
    DBGrid1: TDBGrid;
    SpeedButton1: TSpeedButton;
    SpeedButton2: TSpeedButton;
    procedure SpeedButton1Click(Sender: TObject);
    procedure SpeedButton2Click(Sender: TObject);
    procedure DBGrid1CellClick(Column: TColumn);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form6: TForm6;

implementation
  uses mdata,newvaccin;
{$R *.dfm}










procedure TForm6.DBGrid1CellClick(Column: TColumn);
begin
if (mdata.data.vaccin1.FieldByName('vaccin_name').Text <> '')
or (mdata.data.vaccin1.FieldByName('vaccin_month').Text <> '')
or (mdata.data.vaccin1.FieldByName('vaccin_lot').Text <> '') then
begin
form7.Edit1.Text:=mdata.data.vaccin1.FieldByName('vaccin_name').Text;
form7.Edit2.Text:=mdata.data.vaccin1.FieldByName('vaccin_month').Text;
form7.Edit3.Text:=mdata.data.vaccin1.FieldByName('vaccin_lot').Text;
end;
end;

procedure TForm6.SpeedButton1Click(Sender: TObject);
begin
form7.Show;
end;

procedure TForm6.SpeedButton2Click(Sender: TObject);
begin
Close;
end;

end.
