unit login;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms,inifiles, Vcl.Dialogs, Vcl.StdCtrls, Vcl.ExtCtrls,
  Vcl.Imaging.jpeg;

type
  TForm1 = class(TForm)
    Panel3: TPanel;
    Label2: TLabel;
    Label3: TLabel;
    Label5: TLabel;
    Edit4: TEdit;
    Edit5: TEdit;
    Button2: TButton;
    Edit6: TEdit;
    Edit7: TEdit;
    Panel2: TPanel;
    Label1: TLabel;
    Label4: TLabel;
    Edit1: TEdit;
    Edit2: TEdit;
    Button1: TButton;
    Edit3: TEdit;
    Label6: TLabel;
    Label7: TLabel;
    procedure FormCreate(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation
  uses main;
{$R *.dfm}



procedure TForm1.Button1Click(Sender: TObject);
begin
edit3.Text:='1';
  with Tinifile.Create(ChangeFileExt(Application.ExeName,'.ini')) do
    begin
    writestring('username','name',edit1.text);
    writestring('password','pass',edit2.text);
    writestring('pos','pos',edit3.text);
    end;
  showmessage(' �� ������� ��� ����� ����� ������� ������ ������ ');
  application.Terminate;
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
if (edit4.Text = edit6.text) and (edit5.Text = edit7.text) then
  form2.Show
else
  showmessage(' ��� �� ���� ������ �� ��� �������� ���� ����� �������� ');
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
    with Tinifile.Create(ChangeFileExt(Application.ExeName,'.ini')) do
      edit3.Text:=readstring('pos','pos',edit3.Text);
    if edit3.Text = '0' then
      begin
         showmessage(' ��� ���� ������� ���� �� �������� ');
         form1.Caption:=' ������� ';
         panel3.Hide;
      end
    else
    if edit3.Text = '1' then
      begin
         form1.Caption:=' ������ ';
         panel2.hide;
         with Tinifile.Create(ChangeFileExt(Application.ExeName,'.ini')) do
         begin
           edit6.Text:=readstring('username','name',edit6.text);
           edit7.Text:=readstring('password','pass',edit7.text);
         end;
      end;
end;

end.
