unit addinj;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.ComCtrls,DateUtils, Vcl.StdCtrls, Vcl.ExtCtrls,
  Vcl.Buttons;

type
  TForm5 = class(TForm)
    Panel1: TPanel;
    Panel2: TPanel;
    Label1: TLabel;
    ComboBox1: TComboBox;
    Panel3: TPanel;
    Label2: TLabel;
    Label3: TLabel;
    ComboBox2: TComboBox;
    DateTimePicker1: TDateTimePicker;
    SpeedButton1: TSpeedButton;
    SpeedButton2: TSpeedButton;
    SpeedButton3: TSpeedButton;
    SpeedButton4: TSpeedButton;
    procedure FormShow(Sender: TObject);
    procedure SpeedButton1Click(Sender: TObject);
    procedure SpeedButton2Click(Sender: TObject);
    procedure SpeedButton3Click(Sender: TObject);
    procedure SpeedButton4Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form5: TForm5;

implementation
  uses mdata;
{$R *.dfm}




//--------------------------------combo append and vaccin choice ---------------
procedure TForm5.FormShow(Sender: TObject);
var i,s:integer;
mydate: TDateTime;
mlist : tstringlist;
begin
panel3.Hide;
panel1.Caption:= ' ����� ����� ������� :   '  + mdata.data.childfullname.Text ;
with mdata.data.vaccin do
begin
  active:=false;
  sql.Clear;
  sql.Add('select * from vaccin');
  sql.Add('where vaccin_month Is Not Null ');
  active:=true;
end;

combobox1.Clear;
mlist := TStringList.Create;
while not mdata.data.vaccin.eof do
  begin
    combobox1.Items.Append(mdata.data.vaccin.FieldByName('vaccin_name').value);
    mlist.Add(mdata.data.vaccinvaccin_month.Text);
    mdata.data.vaccin.Next;
  end;
mydate:=strtodate(mdata.data.child['child_birth']);
i:=0;
s:=mdata.data.vaccin.RecNo-1;
for i:=0 to mlist.Count-1 do
 begin
  if MonthsBetween(mydate,date) >= mlist[s].ToInteger then
  begin
   combobox1.ItemIndex:=s;
   break
  end;
  s:=s-1;
 end;


combobox2.Clear;
mdata.data.salles.Close;
mdata.data.salles.open;
mdata.data.salles.first;
while not mdata.data.salles.eof do
begin
  combobox2.Items.Append(mdata.data.sallessalle_name.value);
  mdata.data.salles.Next;
end;

end;
//------------------------------------------------------------------------------
//---------------------------teset of vaccin------------------------------------
procedure TForm5.SpeedButton1Click(Sender: TObject);
begin
if (combobox1.Text = '')
    then showmessage('���� ������ ���� ����  ')
else
  begin
   with mdata.data.injection1 do
      begin
        active:=false;
        sql.Clear;
        sql.Add('select * from injection ');
        sql.Add('where child_idi = '+mdata.data.childchild_id.Text);
        sql.Add('and vaccin_name = '+QuotedStr(combobox1.Text) );
        execsql;
        active:=true;
      end;
    if  (data.child.Fields[combobox1.ItemIndex+20].Text <> '')
    or (data.injection1.RecordCount > 0)
    then  showmessage('��� ����� �� ���� ������� �� ��� ���� ������ �� ��� ������')
    else panel3.Show;
  end;
end;
//------------------------------------------------------------------------------


//------------------------  edit injection --------------------------------------
procedure TForm5.SpeedButton2Click(Sender: TObject);
begin
   with mdata.data.injection1 do
      begin
        active:=false;
        sql.Clear;
        sql.Add('select * from injection ');
        sql.Add('where child_idi = '+mdata.data.childchild_id.Text);
        sql.Add('and vaccin_name = '+QuotedStr(combobox1.Text) );
        execsql;
        active:=true;
      end;
 if  (data.child.Fields[combobox1.ItemIndex+20].Text <> '')
    or (data.injection1.RecordCount > 0)
    then  showmessage('��� ����� �� ���� ������� �� ��� ���� ������ �� ��� ������')
 else
  begin
    if (combobox1.Text = '') then showmessage('���� ������ ���� ����  ')
    else
      begin
      data.injection.Insert;
      data.injectionchild_idi.AsString:=data.child.FieldByName('child_id').AsString;
      data.injectionvaccin_name.Text:=combobox1.Text;
      data.injectionvaccin_place.Text:='/';
      data.injectioninjection_date.Text:='/';
      data.injectionvaccin_state.Text:='��';
      data.injectionvaccin_no.Value:=combobox1.ItemIndex+1;
      data.injection.Post;
      form5.Close;
      end;
  end;
end;
//------------------------------------------------------------------------------


//------------------------  add injection --------------------------------------

procedure TForm5.SpeedButton3Click(Sender: TObject);
begin
if (combobox1.Text = '')  then showmessage(' ������ ������ ���� ')
else
 begin
  if (combobox2.Text = '')  then showmessage(' ������ ������ ���� ������ ')
  else
  begin
   with mdata.data.injection1 do
      begin
        active:=false;
        sql.Clear;
        sql.Add('select * from injection ');
        sql.Add('where child_idi = '+mdata.data.childchild_id.Text);
        sql.Add('and vaccin_name = '+QuotedStr(combobox1.Text) );
        execsql;
        active:=true;
      end;
    if  (data.child.Fields[combobox1.ItemIndex+20].Text <> '')
    or (data.injection1.RecordCount > 0)
    then
    begin
      showmessage('��� ����� �� ���� ������� �� ��� ���� ������ �� ��� ������')
    end
    else
    begin
    data.injection.Insert;
    data.injectionchild_idi.AsString:=data.child.FieldByName('child_id').AsString;
    data.injectionvaccin_name.Text:=combobox1.Text;
    data.injectionvaccin_place.Text:=combobox2.Text;
    data.injectioninjection_date.Text:=datetostr(datetimepicker1.date);
    data.injectionvaccin_state.Text:='���';
    data.injectionvaccin_no.Value:=combobox1.ItemIndex+1;
    data.injectionvm.Value:=MonthOf(datetimepicker1.date);
    data.injectionvy.Value:=YearOf(datetimepicker1.date);
    data.injection.Post;
    data.child.edit;
    data.child.Fields[combobox1.ItemIndex+20].Text:=datetostr(datetimepicker1.date);
    data.child.FieldByName('vaccin_m').Value:=MonthOf(datetimepicker1.date);
    data.child.FieldByName('child_salle').Value:=combobox2.Text;
    data.child.FieldByName('vaccin_y').Value:=YearOf(datetimepicker1.date);
    data.child.post;
    form5.Close;
    end;
  end;
 end;

end;
procedure TForm5.SpeedButton4Click(Sender: TObject);
begin
close;
end;

//------------------------------------------------------------------------------



end.
