unit stat;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Data.DB,frxClass, frxDBSet, DateUtils,Vcl.StdCtrls, Vcl.Grids,
  Vcl.DBGrids, Vcl.ComCtrls, Vcl.ExtCtrls, Vcl.Buttons;

type
  TForm16 = class(TForm)
    GroupBox1: TGroupBox;
    Label2: TLabel;
    ComboBox1: TComboBox;
    ProgressBar1: TProgressBar;
    SpeedButton1: TSpeedButton;
    procedure FormShow(Sender: TObject);
    procedure SpeedButton1Click(Sender: TObject);

  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form16: TForm16;

implementation
 uses mdata,main;
{$R *.dfm}






procedure TForm16.FormShow(Sender: TObject);
begin
progressbar1.Position:=0;
end;

procedure TForm16.SpeedButton1Click(Sender: TObject);
var   k,j,i:integer;
      s:string;
      Memo,m,m1: TfrxMemoView;
      Component,c: TfrxComponent;
begin
k:=0;
while k <=2 do
 begin
     i:=1;
    while i<=12 do
     begin
     with mdata.data.child1 do
     begin
       active:=false;
       sql.Clear;
       sql.Add('select * from child');
       sql.Add('where Month(child_birth)='+inttostr(i));
       sql.Add('and year(child_birth)='+inttostr(YearOf(now)-k));
       active:=true;
     end;
     with mdata.data.child2 do
     begin
       active:=false;
       sql.Clear;
       sql.Add('select * from child');
       sql.Add('where Month(child_birth)='+inttostr(i));
       sql.Add('and year(child_birth)='+inttostr(YearOf(now)-k));
       sql.Add('and child_status=''��'' ');
       active:=true;
     end;
     with mdata.data.child3 do
     begin
       active:=false;
       sql.Clear;
       sql.Add('select * from child');
       sql.Add('where Month(child_birth)='+inttostr(i));
       sql.Add('and year(child_birth)='+inttostr(YearOf(now)-k));
       sql.Add('and child_place=''���''');
       sql.Add('and child_status=''���'' ');
       active:=true;
     end;
     mdata.data.stat.Open;
     mdata.data.stat.First;
     while not mdata.data.stat.Eof do
     begin
       if (mdata.data.stat['satat_month'] = inttostr(i))
       and (mdata.data.stat['stat_year'] = inttostr(k)) then
          begin
           mdata.data.stat.Edit;
           mdata.data.stat['v_child']:= mdata.data.child2.RecordCount;
           mdata.data.stat['all_child']:= mdata.data.child1.RecordCount;
           mdata.data.stat['cible_child']:= mdata.data.child3.RecordCount;
           mdata.data.stat.Post;
          end;
        mdata.data.stat.Next;
     end;
         j:=1;
        s:='v'+inttostr(i);
        while j<=12 do
        begin
         with mdata.data.child4 do
         begin
           close;
           sql.Clear;
           sql.Add('select * from child');
           sql.Add('where Month('+s+')='+inttostr(combobox1.ItemIndex+1));
           sql.Add('and year('+s+')='+inttostr(YearOf(now)));
           sql.Add('and Month(child_birth)='+inttostr(j));
           sql.Add('and year(child_birth)='+inttostr(YearOf(now)-k));
           sql.Add('and child_place=''���''');
           sql.Add('and child_status=''���'' ');
           open;
         end;
         mdata.data.stat.Open;
         mdata.data.stat.First;
         while not mdata.data.stat.Eof do
         begin
           if (mdata.data.stat['satat_month'] = inttostr(j))
           and (mdata.data.stat['stat_year'] = inttostr(k))  then
              begin
               mdata.data.stat.Edit;
               mdata.data.stat[s]:=mdata.data.child4.RecordCount;
               mdata.data.stat.Post;
              end;
            mdata.data.stat.Next;
         end;
         j:=j+1;
        end;
     i:=i+1;
     end;
     k:=k+1;
     progressbar1.Position:=progressbar1.Position+1;
 end;


 i:=1;
     mdata.data.vaccin.Open;
     mdata.data.vaccin.First;
    while not mdata.data.vaccin.Eof do
     begin
      Component := form2.annexe5.FindObject('m'+inttostr(i));
      if Component is TfrxMemoView then
      begin
        Memo := Component as TfrxMemoView;
        Memo.Text := mdata.data.vaccinvaccin_name.Text;
        Memo.HAlign:=haCenter;
        Memo.Font.Size:=6;
      end;
      mdata.data.vaccin.Next;
      i:=i+1;
     end;
     Component := form2.annexe5.FindObject('y1');
     m := Component as TfrxMemoView;
     m.Text := inttostr(YearOf(now));
     c:= form2.annexe5.FindObject('y2');
     m1 := c as TfrxMemoView;
     m1.Text := combobox1.Text;
  form2.annexe5.ShowReport();
  Close;
end;

end.
