unit editvaccin;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, DateUtils,Vcl.ExtCtrls, Vcl.ComCtrls,
  Vcl.Buttons;

type
  TForm8 = class(TForm)
    Panel1: TPanel;
    Panel2: TPanel;
    Label2: TLabel;
    Label3: TLabel;
    ComboBox2: TComboBox;
    Panel3: TPanel;
    ComboBox1: TComboBox;
    Label1: TLabel;
    DateTimePicker1: TDateTimePicker;
    Panel4: TPanel;
    SpeedButton1: TSpeedButton;
    SpeedButton2: TSpeedButton;
    Edit1: TEdit;
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
  Form8: TForm8;

implementation
  uses main,mdata;
{$R *.dfm}




procedure TForm8.ComboBox1Change(Sender: TObject);
begin
if combobox1.Text = '��' then panel2.Hide
else panel2.Show;
end;

procedure TForm8.FormShow(Sender: TObject);
begin
panel1.Caption:= ' ������� ' +data.childfullname.Text+ '  ' +data.injectionvaccin_name.Text+ ' ����� ������ '   ;
combobox2.Clear;
mdata.data.salles.Close;
mdata.data.salles.open;
mdata.data.salles.first;
while not mdata.data.salles.eof do
begin
  combobox2.Items.Append(mdata.data.sallessalle_name.value);
  mdata.data.salles.Next;
end;
combobox2.Text:=mdata.data.injectionvaccin_place.Text;
if combobox1.Text = '��' then panel2.Hide
else panel2.Show;
end;

procedure TForm8.SpeedButton1Click(Sender: TObject);
begin
if combobox1.Text = '���' then
  begin
    data.injection.Edit;
    data.injectionvaccin_state.Text:=combobox1.Text;
    data.injectioninjection_date.Text:=datetostr(datetimepicker1.Date);
    data.injectionvaccin_place.Text:=combobox2.Text;
    data.injectionvm.Value:=MonthOf(datetimepicker1.date);
    data.injectionvy.Value:=YearOf(datetimepicker1.date);
    data.injection.Post;
    data.child.Edit;
    data.child.Fields[data.injectionvaccin_no.value+19].Value:=datetostr(datetimepicker1.Date);
    data.child.Post;
    data.injection.Refresh;
    with mdata.data.injection do
      begin
        active:=false;
        sql.Clear;
        sql.Add('select * from injection ');
        sql.Add('where child_idi = '+mdata.data.childchild_id.Text);
        sql.Add('and vaccin_state = ''���''' );
        sql.Add('order by injection_date ');
        execsql;
        active:=true;
      end;
    mdata.data.injection.Last;
    data.child.Edit;
    mdata.data.childvaccin_m.Value:= mdata.data.injection['vm'];
    mdata.data.childvaccin_y.Value:= mdata.data.injection['vy'];
    mdata.data.childchild_salle.Value:=mdata.data.injectionvaccin_place.Value;
    data.child.Post;
    with mdata.data.injection do
      begin
        active:=false;
        sql.Clear;
        sql.Add('select * from injection ');
        sql.Add('where child_idi = '+mdata.data.childchild_id.Text);
        sql.Add('order by vaccin_no ');
        execsql;
        active:=true;
      end;
    showmessage('�� ������� �����');
    close;
  end
else
  begin
    data.injection.Edit;
    data.injectionvaccin_state.Text:=combobox1.Text;
    data.injectioninjection_date.Text:='/';
    data.injectionvaccin_place.Text:='/';
    data.injection.Post;
    data.child.Edit;
    data.child.Fields[data.injectionvaccin_no.value+19].clear;
    data.child.Post;
    data.injection.Refresh;
    with mdata.data.injection do
      begin
        active:=false;
        sql.Clear;
        sql.Add('select * from injection ');
        sql.Add('where child_idi = '+mdata.data.childchild_id.Text);
        sql.Add('and vaccin_state = ''���''' );
        sql.Add('order by injection_date ');
        execsql;
        active:=true;
      end;
    mdata.data.injection.Last;
    if data.injection.RecordCount > 0 then
    begin
      data.child.Edit;
      mdata.data.childchild_salle.Text:=mdata.data.injectionvaccin_place.Text;
      mdata.data.childvaccin_m.Value:= mdata.data.injection['vm'];
      mdata.data.childvaccin_y.Value:= mdata.data.injection['vy'];
      data.child.Post;
    end
    else
    begin
      data.child.Edit;
      mdata.data.childchild_salle.clear;
      mdata.data.childvaccin_m.clear;
      mdata.data.childvaccin_y.clear;
      data.child.Post;
    end;
    with mdata.data.injection do
      begin
        active:=false;
        sql.Clear;
        sql.Add('select * from injection ');
        sql.Add('where child_idi = '+mdata.data.childchild_id.Text);
        sql.Add('order by vaccin_no ');
        execsql;
        active:=true;
      end;
    showmessage('�� ������� �����');
    close;
  end;
end;

procedure TForm8.SpeedButton2Click(Sender: TObject);
begin
close;
end;

end.
