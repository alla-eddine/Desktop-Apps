unit death;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.ExtCtrls, Vcl.StdCtrls, Vcl.ComCtrls,
  Vcl.Buttons;

type
  TForm10 = class(TForm)
    Panel1: TPanel;
    GroupBox1: TGroupBox;
    Label1: TLabel;
    DateTimePicker1: TDateTimePicker;
    Panel2: TPanel;
    ComboBox1: TComboBox;
    Label2: TLabel;
    SpeedButton1: TSpeedButton;
    SpeedButton2: TSpeedButton;
    procedure FormShow(Sender: TObject);
    procedure ComboBox1Change(Sender: TObject);
    procedure SpeedButton1Click(Sender: TObject);
    procedure SpeedButton2Click(Sender: TObject);

  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form10: TForm10;

implementation
   uses main,mdata;
{$R *.dfm}






procedure TForm10.ComboBox1Change(Sender: TObject);
begin
if combobox1.Text = '‰⁄„' then
  begin
   label1.Hide;
   datetimepicker1.Hide;
  end
else
 begin
   label1.show;
   datetimepicker1.show;
  end;
end;

procedure TForm10.FormShow(Sender: TObject);
begin
panel1.Caption:='  ”ÃÌ· «·„Ê·Êœ : '+data.childfullname.Text+' ›Ì ”Ã· «·Ê›Ì«  ';
if combobox1.Text = '‰⁄„' then
  begin
   label1.Hide;
   datetimepicker1.Hide;
  end
else
 begin
   label1.Show;
   datetimepicker1.Show;
  end;
end;

procedure TForm10.SpeedButton1Click(Sender: TObject);
begin
if combobox1.Text <> '' then
   begin
    data.child.edit;
    if combobox1.Text = '·«' then
      begin
        data.childchild_death.Text:=datetostr(datetimepicker1.Date);
        data.childchild_status.Text:=combobox1.Text;
      end
    else
      begin
        data.childchild_death.Text:='';
        data.childchild_status.Text:=combobox1.Text;
      end;
    data.child.Post;
    showmessage('  „ «· Œ“Ì‰ »‰Ã«Õ ');
   end
else
    showmessage(' «·—Ã«¡ ≈Œ Ì«— «·„Ê·Êœ √Ê·«');

form10.Close;
end;

procedure TForm10.SpeedButton2Click(Sender: TObject);
begin
form10.Close;
end;


end.
