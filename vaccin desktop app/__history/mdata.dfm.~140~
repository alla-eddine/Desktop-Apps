object data: Tdata
  OldCreateOrder = False
  Height = 333
  Width = 789
  object ADOConnection1: TADOConnection
    Connected = True
    ConnectionString = 
      'Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source=vacci' +
      'n.mdb;Mode=ReadWrite;Persist Security Info=False;Jet OLEDB:Syste' +
      'm database="";Jet OLEDB:Registry Path="";Jet OLEDB:Database Pass' +
      'word="";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=' +
      '0;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Tran' +
      'sactions=1;Jet OLEDB:New Database Password="";Jet OLEDB:Create S' +
      'ystem Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:' +
      'Don'#39't Copy Locale on Compact=False;Jet OLEDB:Compact Without Rep' +
      'lica Repair=False;Jet OLEDB:SFP=False'
    LoginPrompt = False
    Mode = cmReadWrite
    Provider = 'Microsoft.Jet.OLEDB.4.0'
    Left = 32
    Top = 8
  end
  object child: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    AfterInsert = childAfterInsert
    AfterEdit = childAfterEdit
    AfterPost = childAfterPost
    OnCalcFields = childCalcFields
    Parameters = <>
    SQL.Strings = (
      'select *,child_ln &" "& child_fn as fullname  from child'
      'order by (child_cn)')
    Left = 104
    Top = 8
    object childchild_id: TAutoIncField
      FieldName = 'child_id'
      ReadOnly = True
    end
    object childchild_cn: TIntegerField
      FieldName = 'child_cn'
    end
    object childchild_fn: TWideStringField
      FieldName = 'child_fn'
      Size = 25
    end
    object childchild_ln: TWideStringField
      FieldName = 'child_ln'
      Size = 25
    end
    object childchild_f: TWideStringField
      FieldName = 'child_f'
      Size = 25
    end
    object childchild_birth: TDateTimeField
      FieldName = 'child_birth'
    end
    object childchild_adress: TWideStringField
      FieldName = 'child_adress'
      Size = 255
    end
    object childchild_born: TWideStringField
      FieldName = 'child_born'
      Size = 25
    end
    object childchild_status: TWideStringField
      FieldName = 'child_status'
      Size = 5
    end
    object childchild_city: TWideStringField
      FieldName = 'child_city'
      Size = 25
    end
    object childchild_place: TWideStringField
      FieldName = 'child_place'
      Size = 25
    end
    object childchild_year: TWideStringField
      FieldName = 'child_year'
      Size = 4
    end
    object childphone: TWideStringField
      FieldName = 'phone'
      Size = 10
    end
    object childvaccin_m: TIntegerField
      FieldName = 'vaccin_m'
    end
    object childfullname: TStringField
      FieldKind = fkCalculated
      FieldName = 'fullname'
      Size = 40
      Calculated = True
    end
    object childchild_num: TIntegerField
      FieldKind = fkCalculated
      FieldName = 'child_num'
      Calculated = True
    end
    object childchild_salle: TWideStringField
      FieldName = 'child_salle'
      Size = 50
    end
    object childage: TStringField
      FieldKind = fkCalculated
      FieldName = 'age'
      Calculated = True
    end
    object childvaccin_y: TIntegerField
      FieldName = 'vaccin_y'
    end
    object childchild_death: TWideStringField
      FieldName = 'child_death'
      Size = 10
    end
    object childv1: TWideStringField
      FieldName = 'v1'
      Size = 10
    end
    object childv2: TWideStringField
      FieldName = 'v2'
      Size = 10
    end
    object childv3: TWideStringField
      FieldName = 'v3'
      Size = 10
    end
    object childv4: TWideStringField
      FieldName = 'v4'
      Size = 10
    end
    object childv5: TWideStringField
      FieldName = 'v5'
      Size = 10
    end
    object childv6: TWideStringField
      FieldName = 'v6'
      Size = 10
    end
    object childv7: TWideStringField
      FieldName = 'v7'
      Size = 10
    end
    object childv8: TWideStringField
      FieldName = 'v8'
      Size = 10
    end
    object childv9: TWideStringField
      FieldName = 'v9'
      Size = 10
    end
    object childv10: TWideStringField
      FieldName = 'v10'
      Size = 10
    end
    object childv11: TWideStringField
      FieldName = 'v11'
      Size = 10
    end
    object childv12: TWideStringField
      FieldName = 'v12'
      Size = 10
    end
  end
  object childdata: TDataSource
    DataSet = child
    Left = 104
    Top = 64
  end
  object years: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from years')
    Left = 256
    Top = 8
    object yearsyear_id: TAutoIncField
      FieldName = 'year_id'
      ReadOnly = True
    end
    object yearsyears: TWideStringField
      FieldName = 'years'
      Size = 4
    end
  end
  object vaccin: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    OnCalcFields = vaccinCalcFields
    Parameters = <>
    SQL.Strings = (
      'select * from vaccin'
      '')
    Left = 216
    Top = 8
    object vaccinvaccin_id: TAutoIncField
      FieldName = 'vaccin_id'
      ReadOnly = True
    end
    object vaccinvaccin_name: TWideStringField
      FieldName = 'vaccin_name'
      Size = 25
    end
    object vaccinvaccin_lot: TWideStringField
      FieldName = 'vaccin_lot'
      Size = 50
    end
    object vaccinvaccin_month: TIntegerField
      FieldName = 'vaccin_month'
    end
    object vaccinvaccin_num: TIntegerField
      FieldKind = fkCalculated
      FieldName = 'vaccin_num'
      Calculated = True
    end
  end
  object vaccindata: TDataSource
    DataSet = vaccin1
    Left = 200
    Top = 64
  end
  object injection: TADOQuery
    Connection = ADOConnection1
    CursorType = ctStatic
    OnCalcFields = injectionCalcFields
    Parameters = <>
    SQL.Strings = (
      'select * from injection')
    Left = 160
    Top = 8
    object injectioninjection_id: TAutoIncField
      FieldName = 'injection_id'
      ReadOnly = True
    end
    object injectionvaccin_name: TWideStringField
      FieldName = 'vaccin_name'
      Size = 25
    end
    object injectionchild_idi: TIntegerField
      FieldName = 'child_idi'
    end
    object injectionvaccin_state: TWideStringField
      FieldName = 'vaccin_state'
      Size = 5
    end
    object injectioninjection_date: TWideStringField
      FieldName = 'injection_date'
      Size = 10
    end
    object injectionvaccin_place: TWideStringField
      FieldName = 'vaccin_place'
      Size = 75
    end
    object injectionvaccin_no: TIntegerField
      FieldName = 'vaccin_no'
    end
    object injectionvm: TIntegerField
      FieldName = 'vm'
    end
    object injectionvy: TIntegerField
      FieldName = 'vy'
    end
  end
  object injectiondata: TDataSource
    DataSet = injection
    Left = 152
    Top = 64
  end
  object annexe3: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from child')
    Left = 96
    Top = 112
    object annexe3child_id: TAutoIncField
      FieldName = 'child_id'
      ReadOnly = True
    end
    object annexe3child_cn: TIntegerField
      FieldName = 'child_cn'
    end
    object annexe3child_fn: TWideStringField
      FieldName = 'child_fn'
      Size = 25
    end
    object annexe3child_ln: TWideStringField
      FieldName = 'child_ln'
      Size = 25
    end
    object annexe3child_f: TWideStringField
      FieldName = 'child_f'
      Size = 25
    end
    object annexe3child_birth: TDateTimeField
      FieldName = 'child_birth'
    end
    object annexe3child_adress: TWideStringField
      FieldName = 'child_adress'
      Size = 255
    end
    object annexe3child_born: TWideStringField
      FieldName = 'child_born'
      Size = 25
    end
    object annexe3child_status: TWideStringField
      FieldName = 'child_status'
      Size = 5
    end
    object annexe3child_city: TWideStringField
      FieldName = 'child_city'
      Size = 25
    end
    object annexe3child_place: TWideStringField
      FieldName = 'child_place'
      Size = 25
    end
    object annexe3child_year: TWideStringField
      FieldName = 'child_year'
      Size = 4
    end
    object annexe3phone: TWideStringField
      FieldName = 'phone'
      Size = 10
    end
    object annexe3vaccin_m: TIntegerField
      FieldName = 'vaccin_m'
    end
    object annexe3child_salle: TWideStringField
      FieldName = 'child_salle'
      Size = 50
    end
    object annexe3vaccin_y: TIntegerField
      FieldName = 'vaccin_y'
    end
    object annexe3v1: TWideStringField
      FieldName = 'v1'
      Size = 10
    end
    object annexe3v2: TWideStringField
      FieldName = 'v2'
      Size = 10
    end
    object annexe3v3: TWideStringField
      FieldName = 'v3'
      Size = 10
    end
    object annexe3v4: TWideStringField
      FieldName = 'v4'
      Size = 10
    end
    object annexe3v5: TWideStringField
      FieldName = 'v5'
      Size = 10
    end
    object annexe3v6: TWideStringField
      FieldName = 'v6'
      Size = 10
    end
    object annexe3v7: TWideStringField
      FieldName = 'v7'
      Size = 10
    end
    object annexe3v8: TWideStringField
      FieldName = 'v8'
      Size = 10
    end
    object annexe3v9: TWideStringField
      FieldName = 'v9'
      Size = 10
    end
    object annexe3v10: TWideStringField
      FieldName = 'v10'
      Size = 10
    end
    object annexe3v11: TWideStringField
      FieldName = 'v11'
      Size = 10
    end
    object annexe3v12: TWideStringField
      FieldName = 'v12'
      Size = 10
    end
    object annexe3child_death: TWideStringField
      FieldName = 'child_death'
      Size = 10
    end
  end
  object fiche: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from child')
    Left = 144
    Top = 112
    object fichechild_id: TAutoIncField
      FieldName = 'child_id'
      ReadOnly = True
    end
    object fichechild_cn: TIntegerField
      FieldName = 'child_cn'
    end
    object fichechild_fn: TWideStringField
      FieldName = 'child_fn'
      Size = 25
    end
    object fichechild_ln: TWideStringField
      FieldName = 'child_ln'
      Size = 25
    end
    object fichechild_f: TWideStringField
      FieldName = 'child_f'
      Size = 25
    end
    object fichechild_birth: TDateTimeField
      FieldName = 'child_birth'
    end
    object fichechild_adress: TWideStringField
      FieldName = 'child_adress'
      Size = 255
    end
    object fichechild_born: TWideStringField
      FieldName = 'child_born'
      Size = 25
    end
    object fichechild_status: TWideStringField
      FieldName = 'child_status'
      Size = 5
    end
    object fichechild_city: TWideStringField
      FieldName = 'child_city'
      Size = 25
    end
    object fichechild_place: TWideStringField
      FieldName = 'child_place'
      Size = 25
    end
    object fichechild_year: TWideStringField
      FieldName = 'child_year'
      Size = 4
    end
    object fichephone: TWideStringField
      FieldName = 'phone'
      Size = 10
    end
    object fichevaccin_m: TIntegerField
      FieldName = 'vaccin_m'
    end
    object fichechild_salle: TWideStringField
      FieldName = 'child_salle'
      Size = 50
    end
    object fichevaccin_y: TIntegerField
      FieldName = 'vaccin_y'
    end
    object fichev1: TWideStringField
      FieldName = 'v1'
      Size = 10
    end
    object fichev2: TWideStringField
      FieldName = 'v2'
      Size = 10
    end
    object fichev3: TWideStringField
      FieldName = 'v3'
      Size = 10
    end
    object fichev4: TWideStringField
      FieldName = 'v4'
      Size = 10
    end
    object fichev5: TWideStringField
      FieldName = 'v5'
      Size = 10
    end
    object fichev6: TWideStringField
      FieldName = 'v6'
      Size = 10
    end
    object fichev7: TWideStringField
      FieldName = 'v7'
      Size = 10
    end
    object fichev8: TWideStringField
      FieldName = 'v8'
      Size = 10
    end
    object fichev9: TWideStringField
      FieldName = 'v9'
      Size = 10
    end
    object fichev10: TWideStringField
      FieldName = 'v10'
      Size = 10
    end
    object fichev11: TWideStringField
      FieldName = 'v11'
      Size = 10
    end
    object fichev12: TWideStringField
      FieldName = 'v12'
      Size = 10
    end
    object fichechild_death: TWideStringField
      FieldName = 'child_death'
      Size = 10
    end
  end
  object annexe2: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'SELECT *  FROM CHILD')
    Left = 200
    Top = 112
    object annexe2child_id: TAutoIncField
      FieldName = 'child_id'
      ReadOnly = True
    end
    object annexe2child_cn: TIntegerField
      FieldName = 'child_cn'
    end
    object annexe2child_fn: TWideStringField
      FieldName = 'child_fn'
      Size = 25
    end
    object annexe2child_ln: TWideStringField
      FieldName = 'child_ln'
      Size = 25
    end
    object annexe2child_f: TWideStringField
      FieldName = 'child_f'
      Size = 25
    end
    object annexe2child_birth: TDateTimeField
      FieldName = 'child_birth'
    end
    object annexe2child_adress: TWideStringField
      FieldName = 'child_adress'
      Size = 255
    end
    object annexe2child_born: TWideStringField
      FieldName = 'child_born'
      Size = 25
    end
    object annexe2child_status: TWideStringField
      FieldName = 'child_status'
      Size = 5
    end
    object annexe2child_city: TWideStringField
      FieldName = 'child_city'
      Size = 25
    end
    object annexe2child_place: TWideStringField
      FieldName = 'child_place'
      Size = 25
    end
    object annexe2child_year: TWideStringField
      FieldName = 'child_year'
      Size = 4
    end
    object annexe2phone: TWideStringField
      FieldName = 'phone'
      Size = 10
    end
    object annexe2vaccin_m: TIntegerField
      FieldName = 'vaccin_m'
    end
    object annexe2child_salle: TWideStringField
      FieldName = 'child_salle'
      Size = 50
    end
    object annexe2vaccin_y: TIntegerField
      FieldName = 'vaccin_y'
    end
    object annexe2v1: TWideStringField
      FieldName = 'v1'
      Size = 10
    end
    object annexe2v2: TWideStringField
      FieldName = 'v2'
      Size = 10
    end
    object annexe2v3: TWideStringField
      FieldName = 'v3'
      Size = 10
    end
    object annexe2v4: TWideStringField
      FieldName = 'v4'
      Size = 10
    end
    object annexe2v5: TWideStringField
      FieldName = 'v5'
      Size = 10
    end
    object annexe2v6: TWideStringField
      FieldName = 'v6'
      Size = 10
    end
    object annexe2v7: TWideStringField
      FieldName = 'v7'
      Size = 10
    end
    object annexe2v8: TWideStringField
      FieldName = 'v8'
      Size = 10
    end
    object annexe2v9: TWideStringField
      FieldName = 'v9'
      Size = 10
    end
    object annexe2v10: TWideStringField
      FieldName = 'v10'
      Size = 10
    end
    object annexe2v11: TWideStringField
      FieldName = 'v11'
      Size = 10
    end
    object annexe2v12: TWideStringField
      FieldName = 'v12'
      Size = 10
    end
    object annexe2child_death: TWideStringField
      FieldName = 'child_death'
      Size = 10
    end
  end
  object street: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select  * from street')
    Left = 752
    Top = 16
    object streetstreet_id: TAutoIncField
      FieldName = 'street_id'
      ReadOnly = True
    end
    object streetstreet_name: TWideStringField
      FieldName = 'street_name'
      Size = 50
    end
  end
  object streetdata: TDataSource
    DataSet = street
    Left = 752
    Top = 64
  end
  object salles: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select   * from salles')
    Left = 720
    Top = 16
    object sallessalle_id: TAutoIncField
      FieldName = 'salle_id'
      ReadOnly = True
    end
    object sallessalle_name: TWideStringField
      FieldName = 'salle_name'
      Size = 50
    end
  end
  object sallesdata: TDataSource
    DataSet = salles
    Left = 720
    Top = 64
  end
  object stat: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from stat'
      'order by satat_id')
    Left = 400
    Top = 64
    object statsatat_id: TAutoIncField
      FieldName = 'satat_id'
      ReadOnly = True
    end
    object statmonth_name: TWideStringField
      FieldName = 'month_name'
      Size = 4
    end
    object statsatat_month: TIntegerField
      FieldName = 'satat_month'
    end
    object statstat_year: TIntegerField
      FieldName = 'stat_year'
    end
    object statall_child: TIntegerField
      FieldName = 'all_child'
    end
    object statv_child: TIntegerField
      FieldName = 'v_child'
    end
    object statcible_child: TIntegerField
      FieldName = 'cible_child'
    end
    object statv1: TIntegerField
      FieldName = 'v1'
    end
    object statv2: TIntegerField
      FieldName = 'v2'
    end
    object statv3: TIntegerField
      FieldName = 'v3'
    end
    object statv4: TIntegerField
      FieldName = 'v4'
    end
    object statv5: TIntegerField
      FieldName = 'v5'
    end
    object statv6: TIntegerField
      FieldName = 'v6'
    end
    object statv7: TIntegerField
      FieldName = 'v7'
    end
    object statv8: TIntegerField
      FieldName = 'v8'
    end
    object statv9: TIntegerField
      FieldName = 'v9'
    end
    object statv10: TIntegerField
      FieldName = 'v10'
    end
    object statv11: TIntegerField
      FieldName = 'v11'
    end
    object statv12: TIntegerField
      FieldName = 'v12'
    end
  end
  object child1: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from child')
    Left = 400
    Top = 8
  end
  object child2: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from child')
    Left = 448
    Top = 8
  end
  object child3: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from child')
    Left = 496
    Top = 8
  end
  object child4: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from child')
    Left = 536
    Top = 8
  end
  object stat2: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from stat'
      'where satat_month between 4 and 6'
      'and stat_year = 0'
      '')
    Left = 496
    Top = 64
    object AutoIncField1: TAutoIncField
      FieldName = 'satat_id'
      ReadOnly = True
    end
    object WideStringField1: TWideStringField
      FieldName = 'month_name'
      Size = 4
    end
    object stat2stat_year: TIntegerField
      FieldName = 'stat_year'
    end
    object stat2satat_month: TIntegerField
      FieldName = 'satat_month'
    end
    object stat2all_child: TIntegerField
      FieldName = 'all_child'
    end
    object IntegerField1: TIntegerField
      FieldName = 'v_child'
    end
    object IntegerField2: TIntegerField
      FieldName = 'cible_child'
    end
    object IntegerField3: TIntegerField
      FieldName = 'v1'
    end
    object IntegerField4: TIntegerField
      FieldName = 'v2'
    end
    object IntegerField5: TIntegerField
      FieldName = 'v3'
    end
    object IntegerField6: TIntegerField
      FieldName = 'v4'
    end
    object IntegerField7: TIntegerField
      FieldName = 'v5'
    end
    object IntegerField8: TIntegerField
      FieldName = 'v6'
    end
    object IntegerField9: TIntegerField
      FieldName = 'v7'
    end
    object IntegerField10: TIntegerField
      FieldName = 'v8'
    end
    object IntegerField11: TIntegerField
      FieldName = 'v9'
    end
    object IntegerField12: TIntegerField
      FieldName = 'v10'
    end
    object IntegerField13: TIntegerField
      FieldName = 'v11'
    end
    object IntegerField14: TIntegerField
      FieldName = 'v12'
    end
  end
  object stat1: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from stat'
      'where satat_month<=3'
      'and stat_year = 0')
    Left = 448
    Top = 64
    object AutoIncField2: TAutoIncField
      FieldName = 'satat_id'
      ReadOnly = True
    end
    object WideStringField2: TWideStringField
      FieldName = 'month_name'
      Size = 4
    end
    object IntegerField15: TIntegerField
      FieldName = 'stat_year'
    end
    object IntegerField16: TIntegerField
      FieldName = 'satat_month'
    end
    object IntegerField17: TIntegerField
      FieldName = 'all_child'
    end
    object IntegerField18: TIntegerField
      FieldName = 'v_child'
    end
    object IntegerField19: TIntegerField
      FieldName = 'cible_child'
    end
    object IntegerField20: TIntegerField
      FieldName = 'v1'
    end
    object IntegerField21: TIntegerField
      FieldName = 'v2'
    end
    object IntegerField22: TIntegerField
      FieldName = 'v3'
    end
    object IntegerField23: TIntegerField
      FieldName = 'v4'
    end
    object IntegerField24: TIntegerField
      FieldName = 'v5'
    end
    object IntegerField25: TIntegerField
      FieldName = 'v6'
    end
    object IntegerField26: TIntegerField
      FieldName = 'v7'
    end
    object IntegerField27: TIntegerField
      FieldName = 'v8'
    end
    object IntegerField28: TIntegerField
      FieldName = 'v9'
    end
    object IntegerField29: TIntegerField
      FieldName = 'v10'
    end
    object IntegerField30: TIntegerField
      FieldName = 'v11'
    end
    object IntegerField31: TIntegerField
      FieldName = 'v12'
    end
  end
  object stat3: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from stat'
      'where satat_month between 7 and 9'
      'and stat_year = 0'
      ''
      '')
    Left = 536
    Top = 64
    object AutoIncField3: TAutoIncField
      FieldName = 'satat_id'
      ReadOnly = True
    end
    object WideStringField3: TWideStringField
      FieldName = 'month_name'
      Size = 4
    end
    object IntegerField32: TIntegerField
      FieldName = 'stat_year'
    end
    object IntegerField33: TIntegerField
      FieldName = 'satat_month'
    end
    object IntegerField34: TIntegerField
      FieldName = 'all_child'
    end
    object IntegerField35: TIntegerField
      FieldName = 'v_child'
    end
    object IntegerField36: TIntegerField
      FieldName = 'cible_child'
    end
    object IntegerField37: TIntegerField
      FieldName = 'v1'
    end
    object IntegerField38: TIntegerField
      FieldName = 'v2'
    end
    object IntegerField39: TIntegerField
      FieldName = 'v3'
    end
    object IntegerField40: TIntegerField
      FieldName = 'v4'
    end
    object IntegerField41: TIntegerField
      FieldName = 'v5'
    end
    object IntegerField42: TIntegerField
      FieldName = 'v6'
    end
    object IntegerField43: TIntegerField
      FieldName = 'v7'
    end
    object IntegerField44: TIntegerField
      FieldName = 'v8'
    end
    object IntegerField45: TIntegerField
      FieldName = 'v9'
    end
    object IntegerField46: TIntegerField
      FieldName = 'v10'
    end
    object IntegerField47: TIntegerField
      FieldName = 'v11'
    end
    object IntegerField48: TIntegerField
      FieldName = 'v12'
    end
  end
  object stat4: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from stat'
      'where satat_month between 10 and 12'
      'and stat_year = 0'
      ''
      ''
      '')
    Left = 400
    Top = 112
    object AutoIncField4: TAutoIncField
      FieldName = 'satat_id'
      ReadOnly = True
    end
    object WideStringField4: TWideStringField
      FieldName = 'month_name'
      Size = 4
    end
    object IntegerField49: TIntegerField
      FieldName = 'stat_year'
    end
    object IntegerField50: TIntegerField
      FieldName = 'satat_month'
    end
    object IntegerField51: TIntegerField
      FieldName = 'all_child'
    end
    object IntegerField52: TIntegerField
      FieldName = 'v_child'
    end
    object IntegerField53: TIntegerField
      FieldName = 'cible_child'
    end
    object IntegerField54: TIntegerField
      FieldName = 'v1'
    end
    object IntegerField55: TIntegerField
      FieldName = 'v2'
    end
    object IntegerField56: TIntegerField
      FieldName = 'v3'
    end
    object IntegerField57: TIntegerField
      FieldName = 'v4'
    end
    object IntegerField58: TIntegerField
      FieldName = 'v5'
    end
    object IntegerField59: TIntegerField
      FieldName = 'v6'
    end
    object IntegerField60: TIntegerField
      FieldName = 'v7'
    end
    object IntegerField61: TIntegerField
      FieldName = 'v8'
    end
    object IntegerField62: TIntegerField
      FieldName = 'v9'
    end
    object IntegerField63: TIntegerField
      FieldName = 'v10'
    end
    object IntegerField64: TIntegerField
      FieldName = 'v11'
    end
    object IntegerField65: TIntegerField
      FieldName = 'v12'
    end
  end
  object stat5: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from stat'
      'where satat_month<=3'
      'and stat_year = 1'
      '')
    Left = 448
    Top = 112
    object AutoIncField5: TAutoIncField
      FieldName = 'satat_id'
      ReadOnly = True
    end
    object WideStringField5: TWideStringField
      FieldName = 'month_name'
      Size = 4
    end
    object IntegerField66: TIntegerField
      FieldName = 'stat_year'
    end
    object IntegerField67: TIntegerField
      FieldName = 'satat_month'
    end
    object IntegerField68: TIntegerField
      FieldName = 'all_child'
    end
    object IntegerField69: TIntegerField
      FieldName = 'v_child'
    end
    object IntegerField70: TIntegerField
      FieldName = 'cible_child'
    end
    object IntegerField71: TIntegerField
      FieldName = 'v1'
    end
    object IntegerField72: TIntegerField
      FieldName = 'v2'
    end
    object IntegerField73: TIntegerField
      FieldName = 'v3'
    end
    object IntegerField74: TIntegerField
      FieldName = 'v4'
    end
    object IntegerField75: TIntegerField
      FieldName = 'v5'
    end
    object IntegerField76: TIntegerField
      FieldName = 'v6'
    end
    object IntegerField77: TIntegerField
      FieldName = 'v7'
    end
    object IntegerField78: TIntegerField
      FieldName = 'v8'
    end
    object IntegerField79: TIntegerField
      FieldName = 'v9'
    end
    object IntegerField80: TIntegerField
      FieldName = 'v10'
    end
    object IntegerField81: TIntegerField
      FieldName = 'v11'
    end
    object IntegerField82: TIntegerField
      FieldName = 'v12'
    end
  end
  object stat6: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from stat'
      'where satat_month between 4 and 6'
      'and stat_year = 1'
      ''
      '')
    Left = 496
    Top = 112
    object AutoIncField6: TAutoIncField
      FieldName = 'satat_id'
      ReadOnly = True
    end
    object WideStringField6: TWideStringField
      FieldName = 'month_name'
      Size = 4
    end
    object IntegerField83: TIntegerField
      FieldName = 'stat_year'
    end
    object IntegerField84: TIntegerField
      FieldName = 'satat_month'
    end
    object IntegerField85: TIntegerField
      FieldName = 'all_child'
    end
    object IntegerField86: TIntegerField
      FieldName = 'v_child'
    end
    object IntegerField87: TIntegerField
      FieldName = 'cible_child'
    end
    object IntegerField88: TIntegerField
      FieldName = 'v1'
    end
    object IntegerField89: TIntegerField
      FieldName = 'v2'
    end
    object IntegerField90: TIntegerField
      FieldName = 'v3'
    end
    object IntegerField91: TIntegerField
      FieldName = 'v4'
    end
    object IntegerField92: TIntegerField
      FieldName = 'v5'
    end
    object IntegerField93: TIntegerField
      FieldName = 'v6'
    end
    object IntegerField94: TIntegerField
      FieldName = 'v7'
    end
    object IntegerField95: TIntegerField
      FieldName = 'v8'
    end
    object IntegerField96: TIntegerField
      FieldName = 'v9'
    end
    object IntegerField97: TIntegerField
      FieldName = 'v10'
    end
    object IntegerField98: TIntegerField
      FieldName = 'v11'
    end
    object IntegerField99: TIntegerField
      FieldName = 'v12'
    end
  end
  object stat7: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from stat'
      'where satat_month between 7 and 9'
      'and stat_year = 1'
      ''
      ''
      '')
    Left = 536
    Top = 112
    object AutoIncField7: TAutoIncField
      FieldName = 'satat_id'
      ReadOnly = True
    end
    object WideStringField7: TWideStringField
      FieldName = 'month_name'
      Size = 4
    end
    object IntegerField100: TIntegerField
      FieldName = 'stat_year'
    end
    object IntegerField101: TIntegerField
      FieldName = 'satat_month'
    end
    object IntegerField102: TIntegerField
      FieldName = 'all_child'
    end
    object IntegerField103: TIntegerField
      FieldName = 'v_child'
    end
    object IntegerField104: TIntegerField
      FieldName = 'cible_child'
    end
    object IntegerField105: TIntegerField
      FieldName = 'v1'
    end
    object IntegerField106: TIntegerField
      FieldName = 'v2'
    end
    object IntegerField107: TIntegerField
      FieldName = 'v3'
    end
    object IntegerField108: TIntegerField
      FieldName = 'v4'
    end
    object IntegerField109: TIntegerField
      FieldName = 'v5'
    end
    object IntegerField110: TIntegerField
      FieldName = 'v6'
    end
    object IntegerField111: TIntegerField
      FieldName = 'v7'
    end
    object IntegerField112: TIntegerField
      FieldName = 'v8'
    end
    object IntegerField113: TIntegerField
      FieldName = 'v9'
    end
    object IntegerField114: TIntegerField
      FieldName = 'v10'
    end
    object IntegerField115: TIntegerField
      FieldName = 'v11'
    end
    object IntegerField116: TIntegerField
      FieldName = 'v12'
    end
  end
  object stat8: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from stat'
      'where satat_month between 10 and 12'
      'and stat_year = 1'
      ''
      ''
      ''
      '')
    Left = 400
    Top = 168
    object AutoIncField8: TAutoIncField
      FieldName = 'satat_id'
      ReadOnly = True
    end
    object WideStringField8: TWideStringField
      FieldName = 'month_name'
      Size = 4
    end
    object IntegerField117: TIntegerField
      FieldName = 'satat_month'
    end
    object IntegerField118: TIntegerField
      FieldName = 'stat_year'
    end
    object IntegerField119: TIntegerField
      FieldName = 'all_child'
    end
    object IntegerField120: TIntegerField
      FieldName = 'v_child'
    end
    object IntegerField121: TIntegerField
      FieldName = 'cible_child'
    end
    object IntegerField122: TIntegerField
      FieldName = 'v1'
    end
    object IntegerField123: TIntegerField
      FieldName = 'v2'
    end
    object IntegerField124: TIntegerField
      FieldName = 'v3'
    end
    object IntegerField125: TIntegerField
      FieldName = 'v4'
    end
    object IntegerField126: TIntegerField
      FieldName = 'v5'
    end
    object IntegerField127: TIntegerField
      FieldName = 'v6'
    end
    object IntegerField128: TIntegerField
      FieldName = 'v7'
    end
    object IntegerField129: TIntegerField
      FieldName = 'v8'
    end
    object IntegerField130: TIntegerField
      FieldName = 'v9'
    end
    object IntegerField131: TIntegerField
      FieldName = 'v10'
    end
    object IntegerField132: TIntegerField
      FieldName = 'v11'
    end
    object IntegerField133: TIntegerField
      FieldName = 'v12'
    end
  end
  object stat10: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from stat'
      'where satat_month between 4 and 6'
      'and stat_year = 2'
      ''
      '')
    Left = 496
    Top = 168
    object AutoIncField9: TAutoIncField
      FieldName = 'satat_id'
      ReadOnly = True
    end
    object WideStringField9: TWideStringField
      FieldName = 'month_name'
      Size = 4
    end
    object IntegerField134: TIntegerField
      FieldName = 'stat_year'
    end
    object IntegerField135: TIntegerField
      FieldName = 'satat_month'
    end
    object IntegerField136: TIntegerField
      FieldName = 'all_child'
    end
    object IntegerField137: TIntegerField
      FieldName = 'v_child'
    end
    object IntegerField138: TIntegerField
      FieldName = 'cible_child'
    end
    object IntegerField139: TIntegerField
      FieldName = 'v1'
    end
    object IntegerField140: TIntegerField
      FieldName = 'v2'
    end
    object IntegerField141: TIntegerField
      FieldName = 'v3'
    end
    object IntegerField142: TIntegerField
      FieldName = 'v4'
    end
    object IntegerField143: TIntegerField
      FieldName = 'v5'
    end
    object IntegerField144: TIntegerField
      FieldName = 'v6'
    end
    object IntegerField145: TIntegerField
      FieldName = 'v7'
    end
    object IntegerField146: TIntegerField
      FieldName = 'v8'
    end
    object IntegerField147: TIntegerField
      FieldName = 'v9'
    end
    object IntegerField148: TIntegerField
      FieldName = 'v10'
    end
    object IntegerField149: TIntegerField
      FieldName = 'v11'
    end
    object IntegerField150: TIntegerField
      FieldName = 'v12'
    end
  end
  object stat9: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from stat'
      'where satat_month<=3'
      'and stat_year = 2')
    Left = 448
    Top = 168
    object AutoIncField10: TAutoIncField
      FieldName = 'satat_id'
      ReadOnly = True
    end
    object WideStringField10: TWideStringField
      FieldName = 'month_name'
      Size = 4
    end
    object IntegerField151: TIntegerField
      FieldName = 'stat_year'
    end
    object IntegerField152: TIntegerField
      FieldName = 'satat_month'
    end
    object IntegerField153: TIntegerField
      FieldName = 'all_child'
    end
    object IntegerField154: TIntegerField
      FieldName = 'v_child'
    end
    object IntegerField155: TIntegerField
      FieldName = 'cible_child'
    end
    object IntegerField156: TIntegerField
      FieldName = 'v1'
    end
    object IntegerField157: TIntegerField
      FieldName = 'v2'
    end
    object IntegerField158: TIntegerField
      FieldName = 'v3'
    end
    object IntegerField159: TIntegerField
      FieldName = 'v4'
    end
    object IntegerField160: TIntegerField
      FieldName = 'v5'
    end
    object IntegerField161: TIntegerField
      FieldName = 'v6'
    end
    object IntegerField162: TIntegerField
      FieldName = 'v7'
    end
    object IntegerField163: TIntegerField
      FieldName = 'v8'
    end
    object IntegerField164: TIntegerField
      FieldName = 'v9'
    end
    object IntegerField165: TIntegerField
      FieldName = 'v10'
    end
    object IntegerField166: TIntegerField
      FieldName = 'v11'
    end
    object IntegerField167: TIntegerField
      FieldName = 'v12'
    end
  end
  object stat11: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from stat'
      'where satat_month between 7 and 9'
      'and stat_year = 2'
      ''
      ''
      '')
    Left = 536
    Top = 168
    object AutoIncField11: TAutoIncField
      FieldName = 'satat_id'
      ReadOnly = True
    end
    object WideStringField11: TWideStringField
      FieldName = 'month_name'
      Size = 4
    end
    object IntegerField168: TIntegerField
      FieldName = 'stat_year'
    end
    object IntegerField169: TIntegerField
      FieldName = 'satat_month'
    end
    object IntegerField170: TIntegerField
      FieldName = 'all_child'
    end
    object IntegerField171: TIntegerField
      FieldName = 'v_child'
    end
    object IntegerField172: TIntegerField
      FieldName = 'cible_child'
    end
    object IntegerField173: TIntegerField
      FieldName = 'v1'
    end
    object IntegerField174: TIntegerField
      FieldName = 'v2'
    end
    object IntegerField175: TIntegerField
      FieldName = 'v3'
    end
    object IntegerField176: TIntegerField
      FieldName = 'v4'
    end
    object IntegerField177: TIntegerField
      FieldName = 'v5'
    end
    object IntegerField178: TIntegerField
      FieldName = 'v6'
    end
    object IntegerField179: TIntegerField
      FieldName = 'v7'
    end
    object IntegerField180: TIntegerField
      FieldName = 'v8'
    end
    object IntegerField181: TIntegerField
      FieldName = 'v9'
    end
    object IntegerField182: TIntegerField
      FieldName = 'v10'
    end
    object IntegerField183: TIntegerField
      FieldName = 'v11'
    end
    object IntegerField184: TIntegerField
      FieldName = 'v12'
    end
  end
  object stat12: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from stat'
      'where satat_month between 10 and 12'
      'and stat_year = 2'
      ''
      ''
      ''
      '')
    Left = 400
    Top = 216
    object AutoIncField12: TAutoIncField
      FieldName = 'satat_id'
      ReadOnly = True
    end
    object WideStringField12: TWideStringField
      FieldName = 'month_name'
      Size = 4
    end
    object IntegerField185: TIntegerField
      FieldName = 'stat_year'
    end
    object IntegerField186: TIntegerField
      FieldName = 'satat_month'
    end
    object IntegerField187: TIntegerField
      FieldName = 'all_child'
    end
    object IntegerField188: TIntegerField
      FieldName = 'v_child'
    end
    object IntegerField189: TIntegerField
      FieldName = 'cible_child'
    end
    object IntegerField190: TIntegerField
      FieldName = 'v1'
    end
    object IntegerField191: TIntegerField
      FieldName = 'v2'
    end
    object IntegerField192: TIntegerField
      FieldName = 'v3'
    end
    object IntegerField193: TIntegerField
      FieldName = 'v4'
    end
    object IntegerField194: TIntegerField
      FieldName = 'v5'
    end
    object IntegerField195: TIntegerField
      FieldName = 'v6'
    end
    object IntegerField196: TIntegerField
      FieldName = 'v7'
    end
    object IntegerField197: TIntegerField
      FieldName = 'v8'
    end
    object IntegerField198: TIntegerField
      FieldName = 'v9'
    end
    object IntegerField199: TIntegerField
      FieldName = 'v10'
    end
    object IntegerField200: TIntegerField
      FieldName = 'v11'
    end
    object IntegerField201: TIntegerField
      FieldName = 'v12'
    end
  end
  object annexe_v: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    Parameters = <>
    SQL.Strings = (
      'select * from child')
    Left = 128
    Top = 168
    object AutoIncField13: TAutoIncField
      FieldName = 'child_id'
      ReadOnly = True
    end
    object IntegerField202: TIntegerField
      FieldName = 'child_cn'
    end
    object WideStringField13: TWideStringField
      FieldName = 'child_fn'
      Size = 25
    end
    object WideStringField14: TWideStringField
      FieldName = 'child_ln'
      Size = 25
    end
    object WideStringField15: TWideStringField
      FieldName = 'child_f'
      Size = 25
    end
    object DateTimeField1: TDateTimeField
      FieldName = 'child_birth'
    end
    object WideStringField16: TWideStringField
      FieldName = 'child_adress'
      Size = 255
    end
    object WideStringField17: TWideStringField
      FieldName = 'child_born'
      Size = 25
    end
    object WideStringField18: TWideStringField
      FieldName = 'child_status'
      Size = 5
    end
    object WideStringField19: TWideStringField
      FieldName = 'child_city'
      Size = 25
    end
    object WideStringField20: TWideStringField
      FieldName = 'child_place'
      Size = 25
    end
    object WideStringField21: TWideStringField
      FieldName = 'child_year'
      Size = 4
    end
    object WideStringField22: TWideStringField
      FieldName = 'phone'
      Size = 10
    end
    object IntegerField203: TIntegerField
      FieldName = 'vaccin_m'
    end
    object WideStringField23: TWideStringField
      FieldName = 'child_salle'
      Size = 50
    end
    object IntegerField204: TIntegerField
      FieldName = 'vaccin_y'
    end
    object WideStringField24: TWideStringField
      FieldName = 'v1'
      Size = 10
    end
    object WideStringField25: TWideStringField
      FieldName = 'v2'
      Size = 10
    end
    object WideStringField26: TWideStringField
      FieldName = 'v3'
      Size = 10
    end
    object WideStringField27: TWideStringField
      FieldName = 'v4'
      Size = 10
    end
    object WideStringField28: TWideStringField
      FieldName = 'v5'
      Size = 10
    end
    object WideStringField29: TWideStringField
      FieldName = 'v6'
      Size = 10
    end
    object WideStringField30: TWideStringField
      FieldName = 'v7'
      Size = 10
    end
    object WideStringField31: TWideStringField
      FieldName = 'v8'
      Size = 10
    end
    object WideStringField32: TWideStringField
      FieldName = 'v9'
      Size = 10
    end
    object WideStringField33: TWideStringField
      FieldName = 'v10'
      Size = 10
    end
    object WideStringField34: TWideStringField
      FieldName = 'v11'
      Size = 10
    end
    object WideStringField35: TWideStringField
      FieldName = 'v12'
      Size = 10
    end
    object WideStringField36: TWideStringField
      FieldName = 'child_death'
      Size = 10
    end
  end
  object injection1: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    OnCalcFields = injectionCalcFields
    Parameters = <>
    SQL.Strings = (
      'select * from injection')
    Left = 264
    Top = 120
    object AutoIncField15: TAutoIncField
      FieldName = 'injection_id'
      ReadOnly = True
    end
    object WideStringField39: TWideStringField
      FieldName = 'vaccin_name'
      Size = 25
    end
    object IntegerField207: TIntegerField
      FieldName = 'child_idi'
    end
    object WideStringField40: TWideStringField
      FieldName = 'vaccin_state'
      Size = 5
    end
    object WideStringField41: TWideStringField
      FieldName = 'injection_date'
      Size = 10
    end
    object WideStringField42: TWideStringField
      FieldName = 'vaccin_place'
      Size = 75
    end
    object IntegerField208: TIntegerField
      FieldName = 'vaccin_no'
    end
    object IntegerField209: TIntegerField
      FieldName = 'vm'
    end
    object IntegerField210: TIntegerField
      FieldName = 'vy'
    end
  end
  object vaccin1: TADOQuery
    Active = True
    Connection = ADOConnection1
    CursorType = ctStatic
    OnCalcFields = vaccin1CalcFields
    Parameters = <>
    SQL.Strings = (
      'select * from vaccin')
    Left = 256
    Top = 72
    object vaccin1vaccin_id: TAutoIncField
      FieldName = 'vaccin_id'
      ReadOnly = True
    end
    object vaccin1vaccin_name: TWideStringField
      FieldName = 'vaccin_name'
      Size = 25
    end
    object vaccin1vaccin_lot: TWideStringField
      FieldName = 'vaccin_lot'
      Size = 50
    end
    object vaccin1vaccin_month: TIntegerField
      FieldName = 'vaccin_month'
    end
    object vaccin1vaccin_no: TIntegerField
      FieldKind = fkCalculated
      FieldName = 'vaccin_no'
      Calculated = True
    end
  end
end
