unit editchild;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs,DateUtils, Vcl.StdCtrls, Vcl.ComCtrls,
  Vcl.Buttons;

type
  TForm4 = class(TForm)
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
  Form4: TForm4;

implementation
  uses main,mdata;
{$R *.dfm}



procedure TForm4.SpeedButton1Click(Sender: TObject);
var a:string;
  Year, Month, Day : Word;
begin
  if (edit1.Text = '') or (edit2.Text = '') or (edit3.Text = '')
  or  (combobox1.Text = '') or  (combobox2.Text = '')
  or (edit4.Text = '')  or (edit6.Text = '')
  then  showmessage(' ��� ���� ��� ���� ��������� ')
  else
  begin
  data.years.Open;
  data.years.First;
  if data.years.IsEmpty = true then
    begin
    data.years.Insert;
    data.years.FieldByName('years').text:='����';
    data.years.Post;
    end;
  DecodeDate(datetimepicker1.date, Year, Month, Day);
  while not data.years.Eof do
  begin
     if data.years.FieldByName('years').text = IntToStr(Year) then
      a:='ok'
      else
      a:='no';
      if a='ok' then break;
      data.years.Next;
  end;
  if a='ok' then
    begin
     data.child.edit;
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
     data.child.Post ;
     form4.Refresh;
     showmessage('�� ������� �����');
     form4.Close;
    end
  else
    begin
     data.years.Insert;
     data.years.FieldByName('years').Value:=IntToStr(Year);
     data.years.Post;
     data.child.edit;
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
     data.child.Post ;
     showmessage('�� ������� �����');
     form4.Refresh;
     form4.Close;
  end;
  end;
end;

procedure TForm4.SpeedButton2Click(Sender: TObject);
begin
close;
end;

end.
