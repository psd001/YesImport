﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="YES")>  _
Partial Public Class YesDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertYES29063(instance As YES29063)
    End Sub
  Partial Private Sub UpdateYES29063(instance As YES29063)
    End Sub
  Partial Private Sub DeleteYES29063(instance As YES29063)
    End Sub
  Partial Private Sub InsertYES29063Pending(instance As YES29063Pending)
    End Sub
  Partial Private Sub UpdateYES29063Pending(instance As YES29063Pending)
    End Sub
  Partial Private Sub DeleteYES29063Pending(instance As YES29063Pending)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.YesImport.My.MySettings.Default.YESConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property YES29063s() As System.Data.Linq.Table(Of YES29063)
		Get
			Return Me.GetTable(Of YES29063)
		End Get
	End Property
	
	Public ReadOnly Property YES29063Pendings() As System.Data.Linq.Table(Of YES29063Pending)
		Get
			Return Me.GetTable(Of YES29063Pending)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.YES29063")>  _
Partial Public Class YES29063
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _StreetNum As String
	
	Private _StreetName As String
	
	Private _Suffix As String
	
	Private _City As String
	
	Private _State As String
	
	Private _Street As String
	
	Private _Zipcode As String
	
	Private _CustCode_CYES As String
	
	Private _OptIn_flag As String
	
	Private _Missed_OPTIN As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnStreetNumChanging(value As String)
    End Sub
    Partial Private Sub OnStreetNumChanged()
    End Sub
    Partial Private Sub OnStreetNameChanging(value As String)
    End Sub
    Partial Private Sub OnStreetNameChanged()
    End Sub
    Partial Private Sub OnSuffixChanging(value As String)
    End Sub
    Partial Private Sub OnSuffixChanged()
    End Sub
    Partial Private Sub OnCityChanging(value As String)
    End Sub
    Partial Private Sub OnCityChanged()
    End Sub
    Partial Private Sub OnStateChanging(value As String)
    End Sub
    Partial Private Sub OnStateChanged()
    End Sub
    Partial Private Sub OnStreetChanging(value As String)
    End Sub
    Partial Private Sub OnStreetChanged()
    End Sub
    Partial Private Sub OnZipcodeChanging(value As String)
    End Sub
    Partial Private Sub OnZipcodeChanged()
    End Sub
    Partial Private Sub OnCustCode_CYESChanging(value As String)
    End Sub
    Partial Private Sub OnCustCode_CYESChanged()
    End Sub
    Partial Private Sub OnOptIn_flagChanging(value As String)
    End Sub
    Partial Private Sub OnOptIn_flagChanged()
    End Sub
    Partial Private Sub OnMissed_OPTINChanging(value As String)
    End Sub
    Partial Private Sub OnMissed_OPTINChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StreetNum", DbType:="VarChar(50)")>  _
	Public Property StreetNum() As String
		Get
			Return Me._StreetNum
		End Get
		Set
			If (String.Equals(Me._StreetNum, value) = false) Then
				Me.OnStreetNumChanging(value)
				Me.SendPropertyChanging
				Me._StreetNum = value
				Me.SendPropertyChanged("StreetNum")
				Me.OnStreetNumChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StreetName", DbType:="VarChar(50)")>  _
	Public Property StreetName() As String
		Get
			Return Me._StreetName
		End Get
		Set
			If (String.Equals(Me._StreetName, value) = false) Then
				Me.OnStreetNameChanging(value)
				Me.SendPropertyChanging
				Me._StreetName = value
				Me.SendPropertyChanged("StreetName")
				Me.OnStreetNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Suffix", DbType:="VarChar(50)")>  _
	Public Property Suffix() As String
		Get
			Return Me._Suffix
		End Get
		Set
			If (String.Equals(Me._Suffix, value) = false) Then
				Me.OnSuffixChanging(value)
				Me.SendPropertyChanging
				Me._Suffix = value
				Me.SendPropertyChanged("Suffix")
				Me.OnSuffixChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_City", DbType:="VarChar(50)")>  _
	Public Property City() As String
		Get
			Return Me._City
		End Get
		Set
			If (String.Equals(Me._City, value) = false) Then
				Me.OnCityChanging(value)
				Me.SendPropertyChanging
				Me._City = value
				Me.SendPropertyChanged("City")
				Me.OnCityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_State", DbType:="VarChar(50)")>  _
	Public Property State() As String
		Get
			Return Me._State
		End Get
		Set
			If (String.Equals(Me._State, value) = false) Then
				Me.OnStateChanging(value)
				Me.SendPropertyChanging
				Me._State = value
				Me.SendPropertyChanged("State")
				Me.OnStateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Street", DbType:="VarChar(50) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property Street() As String
		Get
			Return Me._Street
		End Get
		Set
			If (String.Equals(Me._Street, value) = false) Then
				Me.OnStreetChanging(value)
				Me.SendPropertyChanging
				Me._Street = value
				Me.SendPropertyChanged("Street")
				Me.OnStreetChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Zipcode", DbType:="VarChar(50)")>  _
	Public Property Zipcode() As String
		Get
			Return Me._Zipcode
		End Get
		Set
			If (String.Equals(Me._Zipcode, value) = false) Then
				Me.OnZipcodeChanging(value)
				Me.SendPropertyChanging
				Me._Zipcode = value
				Me.SendPropertyChanged("Zipcode")
				Me.OnZipcodeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CustCode_CYES", DbType:="VarChar(50)")>  _
	Public Property CustCode_CYES() As String
		Get
			Return Me._CustCode_CYES
		End Get
		Set
			If (String.Equals(Me._CustCode_CYES, value) = false) Then
				Me.OnCustCode_CYESChanging(value)
				Me.SendPropertyChanging
				Me._CustCode_CYES = value
				Me.SendPropertyChanged("CustCode_CYES")
				Me.OnCustCode_CYESChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OptIn_flag", DbType:="VarChar(50)")>  _
	Public Property OptIn_flag() As String
		Get
			Return Me._OptIn_flag
		End Get
		Set
			If (String.Equals(Me._OptIn_flag, value) = false) Then
				Me.OnOptIn_flagChanging(value)
				Me.SendPropertyChanging
				Me._OptIn_flag = value
				Me.SendPropertyChanged("OptIn_flag")
				Me.OnOptIn_flagChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Missed_OPTIN", DbType:="VarChar(50)")>  _
	Public Property Missed_OPTIN() As String
		Get
			Return Me._Missed_OPTIN
		End Get
		Set
			If (String.Equals(Me._Missed_OPTIN, value) = false) Then
				Me.OnMissed_OPTINChanging(value)
				Me.SendPropertyChanging
				Me._Missed_OPTIN = value
				Me.SendPropertyChanged("Missed_OPTIN")
				Me.OnMissed_OPTINChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.YES29063Pending")>  _
Partial Public Class YES29063Pending
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Action As String
	
	Private _StreetNum As String
	
	Private _StreetName As String
	
	Private _Suffix As String
	
	Private _City As String
	
	Private _State As String
	
	Private _Street As String
	
	Private _Zipcode As String
	
	Private _CustCode_CYES As String
	
	Private _OptIn_flag As String
	
	Private _Missed_OPTIN As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnActionChanging(value As String)
    End Sub
    Partial Private Sub OnActionChanged()
    End Sub
    Partial Private Sub OnStreetNumChanging(value As String)
    End Sub
    Partial Private Sub OnStreetNumChanged()
    End Sub
    Partial Private Sub OnStreetNameChanging(value As String)
    End Sub
    Partial Private Sub OnStreetNameChanged()
    End Sub
    Partial Private Sub OnSuffixChanging(value As String)
    End Sub
    Partial Private Sub OnSuffixChanged()
    End Sub
    Partial Private Sub OnCityChanging(value As String)
    End Sub
    Partial Private Sub OnCityChanged()
    End Sub
    Partial Private Sub OnStateChanging(value As String)
    End Sub
    Partial Private Sub OnStateChanged()
    End Sub
    Partial Private Sub OnStreetChanging(value As String)
    End Sub
    Partial Private Sub OnStreetChanged()
    End Sub
    Partial Private Sub OnZipcodeChanging(value As String)
    End Sub
    Partial Private Sub OnZipcodeChanged()
    End Sub
    Partial Private Sub OnCustCode_CYESChanging(value As String)
    End Sub
    Partial Private Sub OnCustCode_CYESChanged()
    End Sub
    Partial Private Sub OnOptIn_flagChanging(value As String)
    End Sub
    Partial Private Sub OnOptIn_flagChanged()
    End Sub
    Partial Private Sub OnMissed_OPTINChanging(value As String)
    End Sub
    Partial Private Sub OnMissed_OPTINChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Action", DbType:="VarChar(10)")>  _
	Public Property Action() As String
		Get
			Return Me._Action
		End Get
		Set
			If (String.Equals(Me._Action, value) = false) Then
				Me.OnActionChanging(value)
				Me.SendPropertyChanging
				Me._Action = value
				Me.SendPropertyChanged("Action")
				Me.OnActionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StreetNum", DbType:="VarChar(50)")>  _
	Public Property StreetNum() As String
		Get
			Return Me._StreetNum
		End Get
		Set
			If (String.Equals(Me._StreetNum, value) = false) Then
				Me.OnStreetNumChanging(value)
				Me.SendPropertyChanging
				Me._StreetNum = value
				Me.SendPropertyChanged("StreetNum")
				Me.OnStreetNumChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StreetName", DbType:="VarChar(50)")>  _
	Public Property StreetName() As String
		Get
			Return Me._StreetName
		End Get
		Set
			If (String.Equals(Me._StreetName, value) = false) Then
				Me.OnStreetNameChanging(value)
				Me.SendPropertyChanging
				Me._StreetName = value
				Me.SendPropertyChanged("StreetName")
				Me.OnStreetNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Suffix", DbType:="VarChar(50)")>  _
	Public Property Suffix() As String
		Get
			Return Me._Suffix
		End Get
		Set
			If (String.Equals(Me._Suffix, value) = false) Then
				Me.OnSuffixChanging(value)
				Me.SendPropertyChanging
				Me._Suffix = value
				Me.SendPropertyChanged("Suffix")
				Me.OnSuffixChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_City", DbType:="VarChar(50)")>  _
	Public Property City() As String
		Get
			Return Me._City
		End Get
		Set
			If (String.Equals(Me._City, value) = false) Then
				Me.OnCityChanging(value)
				Me.SendPropertyChanging
				Me._City = value
				Me.SendPropertyChanged("City")
				Me.OnCityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_State", DbType:="VarChar(50)")>  _
	Public Property State() As String
		Get
			Return Me._State
		End Get
		Set
			If (String.Equals(Me._State, value) = false) Then
				Me.OnStateChanging(value)
				Me.SendPropertyChanging
				Me._State = value
				Me.SendPropertyChanged("State")
				Me.OnStateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Street", DbType:="VarChar(50) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property Street() As String
		Get
			Return Me._Street
		End Get
		Set
			If (String.Equals(Me._Street, value) = false) Then
				Me.OnStreetChanging(value)
				Me.SendPropertyChanging
				Me._Street = value
				Me.SendPropertyChanged("Street")
				Me.OnStreetChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Zipcode", DbType:="VarChar(50)")>  _
	Public Property Zipcode() As String
		Get
			Return Me._Zipcode
		End Get
		Set
			If (String.Equals(Me._Zipcode, value) = false) Then
				Me.OnZipcodeChanging(value)
				Me.SendPropertyChanging
				Me._Zipcode = value
				Me.SendPropertyChanged("Zipcode")
				Me.OnZipcodeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CustCode_CYES", DbType:="VarChar(50)")>  _
	Public Property CustCode_CYES() As String
		Get
			Return Me._CustCode_CYES
		End Get
		Set
			If (String.Equals(Me._CustCode_CYES, value) = false) Then
				Me.OnCustCode_CYESChanging(value)
				Me.SendPropertyChanging
				Me._CustCode_CYES = value
				Me.SendPropertyChanged("CustCode_CYES")
				Me.OnCustCode_CYESChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OptIn_flag", DbType:="VarChar(50)")>  _
	Public Property OptIn_flag() As String
		Get
			Return Me._OptIn_flag
		End Get
		Set
			If (String.Equals(Me._OptIn_flag, value) = false) Then
				Me.OnOptIn_flagChanging(value)
				Me.SendPropertyChanging
				Me._OptIn_flag = value
				Me.SendPropertyChanged("OptIn_flag")
				Me.OnOptIn_flagChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Missed_OPTIN", DbType:="VarChar(50)")>  _
	Public Property Missed_OPTIN() As String
		Get
			Return Me._Missed_OPTIN
		End Get
		Set
			If (String.Equals(Me._Missed_OPTIN, value) = false) Then
				Me.OnMissed_OPTINChanging(value)
				Me.SendPropertyChanging
				Me._Missed_OPTIN = value
				Me.SendPropertyChanged("Missed_OPTIN")
				Me.OnMissed_OPTINChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
