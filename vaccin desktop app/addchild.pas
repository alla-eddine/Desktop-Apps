unit addchild;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs,DateUtils, Vcl.StdCtrls, Vcl.ComCtrls,
  Vcl.Buttons;

type
  TForm3 = class(TForm)
    GroupBox1: TGroupBox;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label8: TLabel;
    Label9: TLabel;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    DateTimePicker1: TDateTimePicker;
    ComboBox1: TComboBox;
    Edit4: TEdit;
    Edit6: TEdit;
    ComboBox2: TComboBox;
    GroupBox2: TGroupBox;
    Label10: TLabel;
    ComboBox3: TComboBox;
    Label11: TLabel;
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
  Form3: TForm3;

implementation
  uses mdata,main;
{$R *.dfm}






procedure TForm3.SpeedButton1Click(Sender: TObject);
var a:string;
  Year, Month, Day : Word;
begin
  if (edit1.Text = '') or (edit2.Text = '') or (edit3.Text = '')
  or  (combobox1.Text = '') or  (combobox2.Text = '')
  or (edit4.Text = '')  or (edit6.Text = '')
  then  showmessage(' ÌÃ» ⁄·Ìﬂ „·∆ Ã„Ì⁄ «·„⁄·Ê„«  ')
  else
  begin
  mdata.data.years.Open;
  mdata.data.years.First;
  if mdata.data.years.IsEmpty = true then
    begin
    mdata.data.years.Insert;
    mdata.data.years.FieldByName('years').text:='«·ﬂ·';
    mdata.data.years.Post;
    end;
  DecodeDate(datetimepicker1.date, Year, Month, Day);
  while not data.years.Eof do
  begin
     if mdata.data.years.FieldByName('years').text = IntToStr(Year) then
      a:='ok'
      else
      a:='no';
      if a='ok' then break;
      mdata.data.years.Next;
  end;
  if a='ok' then
    begin
     data.child.Insert;
     data.child.FieldByName('child_cn').Value:=edit1.Text;
     data.child.FieldByName('child_fn').AsString:=edit2.Text;
     data.child.FieldByName('fullname').AsString:=edit2.Text+' '+edit1.Text;
     data.child.FieldByName('child_ln').AsString:=edit3.Text;
     data.child.FieldByName('child_birth').asstring:=datetostr(datetimepicker1.Date);
     data.child.FieldByName('child_city').AsString:=combobox1.Text;
     data.child.FieldByName('child_f').AsString:=edit4.Text;
     data.child.FieldByName('child_born').AsString:=combobox2.Text;
     data.child.FieldByName('child_adress').AsString:=edit6.Text;
     data.child.FieldByName('child_year').value:=YearOf(datetimepicker1.Date);
     data.child.FieldByName('child_place').AsString:=combobox3.Text;
     data.child.FieldByName('child_status').AsString:='‰⁄„';
     data.child.FieldByName('child_death').text:='/';
     data.child.Post ;
     form3.Refresh;
     showmessage(' „ «· Œ“Ì‰ »‰Ã«Õ');
     form3.Close;
    end
  else
    begin
     data.years.Insert;
     data.years.FieldByName('years').Value:=IntToStr(Year);
     data.years.Post;
     data.child.Insert;
     data.child.FieldByName('child_cn').Value:=edit1.Text;
     data.child.FieldByName('child_fn').AsString:=edit2.Text;
     data.child.FieldByName('fullname').AsString:=edit2.Text+' '+edit1.Text;
     data.child.FieldByName('child_ln').AsString:=edit3.Text;
     data.child.FieldByName('child_birth').asstring:=datetostr(datetimepicker1.Date);
     data.child.FieldByName('child_city').AsString:=combobox1.Text;
     data.child.FieldByName('child_f').AsString:=edit4.Text;
     data.child.FieldByName('child_born').AsString:=combobox2.Text;
     data.child.FieldByName('child_adress').AsString:=edit6.Text;
     data.child.FieldByName('child_year').value:=YearOf(datetimepicker1.Date);
     data.child.FieldByName('child_place').AsString:=combobox3.Text;
     data.child.FieldByName('child_status').AsString:='‰⁄„';
     data.child.FieldByName('child_death').text:='/';
     data.child.Post ;
     showmessage(' „ «· Œ“Ì‰ »‰Ã«Õ');
     form3.Refresh;
     form3.Close;
  end;
  end;
end;

procedure TForm3.SpeedButton2Click(Sender: TObject);
begin
close;
end;

end.
