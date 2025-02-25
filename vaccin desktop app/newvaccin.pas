unit newvaccin;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.Buttons;

type
  TForm7 = class(TForm)
    GroupBox4: TGroupBox;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    SpeedButton1: TSpeedButton;
    SpeedButton2: TSpeedButton;
    procedure SpeedButton1Click(Sender: TObject);
    procedure SpeedButton2Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form7: TForm7;

implementation
  uses mdata;
{$R *.dfm}





procedure TForm7.SpeedButton1Click(Sender: TObject);
begin
if (edit1.Text = '')  or (edit3.Text = '') then
    showmessage('«·—Ã«¡ „·∆ Ã„Ì⁄ «·„⁄·Ê„« ')
else
  begin
    mdata.data.vaccin1.Edit;
    mdata.data.vaccin1.FieldByName('vaccin_name').Text:=edit1.Text;
    mdata.data.vaccin1.FieldByName('vaccin_month').Text:=edit2.Text;
    mdata.data.vaccin1.FieldByName('vaccin_lot').Text:=edit3.Text;
    mdata.data.vaccin1.Post;
    showmessage(' „ «· ⁄œÌ· »‰Ã«Õ');
    CLOSE;
  end;
end;

procedure TForm7.SpeedButton2Click(Sender: TObject);
begin
close;
end;

end.
