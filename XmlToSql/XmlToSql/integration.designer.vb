﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.1
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
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


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="orders")>  _
Partial Public Class integrationDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "可扩展性方法定义"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Insertorder(instance As [order])
    End Sub
  Partial Private Sub Updateorder(instance As [order])
    End Sub
  Partial Private Sub Deleteorder(instance As [order])
    End Sub
  Partial Private Sub Insertitem(instance As item)
    End Sub
  Partial Private Sub Updateitem(instance As item)
    End Sub
  Partial Private Sub Deleteitem(instance As item)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.XmlToSql.My.MySettings.Default.ordersConnectionString, mappingSource)
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
	
	Public ReadOnly Property orders() As System.Data.Linq.Table(Of [order])
		Get
			Return Me.GetTable(Of [order])
		End Get
	End Property
	
	Public ReadOnly Property items() As System.Data.Linq.Table(Of item)
		Get
			Return Me.GetTable(Of item)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.orders")>  _
Partial Public Class [order]
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _OrderId As Integer
	
	Private _OrderNumber As Integer
	
	Private _pickup As String
	
	Private _deliver As String
	
	Private _deliverdate As Date
	
	Private _created As Date
	
	Private _items As EntitySet(Of item)
	
    #Region "可扩展性方法定义"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnOrderIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnOrderIdChanged()
    End Sub
    Partial Private Sub OnOrderNumberChanging(value As Integer)
    End Sub
    Partial Private Sub OnOrderNumberChanged()
    End Sub
    Partial Private Sub OnpickupChanging(value As String)
    End Sub
    Partial Private Sub OnpickupChanged()
    End Sub
    Partial Private Sub OndeliverChanging(value As String)
    End Sub
    Partial Private Sub OndeliverChanged()
    End Sub
    Partial Private Sub OndeliverdateChanging(value As Date)
    End Sub
    Partial Private Sub OndeliverdateChanged()
    End Sub
    Partial Private Sub OncreatedChanging(value As Date)
    End Sub
    Partial Private Sub OncreatedChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._items = New EntitySet(Of item)(AddressOf Me.attach_items, AddressOf Me.detach_items)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OrderId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property OrderId() As Integer
		Get
			Return Me._OrderId
		End Get
		Set
			If ((Me._OrderId = value)  _
						= false) Then
				Me.OnOrderIdChanging(value)
				Me.SendPropertyChanging
				Me._OrderId = value
				Me.SendPropertyChanged("OrderId")
				Me.OnOrderIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OrderNumber", DbType:="Int NOT NULL")>  _
	Public Property OrderNumber() As Integer
		Get
			Return Me._OrderNumber
		End Get
		Set
			If ((Me._OrderNumber = value)  _
						= false) Then
				Me.OnOrderNumberChanging(value)
				Me.SendPropertyChanging
				Me._OrderNumber = value
				Me.SendPropertyChanged("OrderNumber")
				Me.OnOrderNumberChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_pickup", DbType:="VarChar(25) NOT NULL", CanBeNull:=false)>  _
	Public Property pickup() As String
		Get
			Return Me._pickup
		End Get
		Set
			If (String.Equals(Me._pickup, value) = false) Then
				Me.OnpickupChanging(value)
				Me.SendPropertyChanging
				Me._pickup = value
				Me.SendPropertyChanged("pickup")
				Me.OnpickupChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_deliver", DbType:="VarChar(25) NOT NULL", CanBeNull:=false)>  _
	Public Property deliver() As String
		Get
			Return Me._deliver
		End Get
		Set
			If (String.Equals(Me._deliver, value) = false) Then
				Me.OndeliverChanging(value)
				Me.SendPropertyChanging
				Me._deliver = value
				Me.SendPropertyChanged("deliver")
				Me.OndeliverChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_deliverdate", DbType:="SmallDateTime NOT NULL")>  _
	Public Property deliverdate() As Date
		Get
			Return Me._deliverdate
		End Get
		Set
			If ((Me._deliverdate = value)  _
						= false) Then
				Me.OndeliverdateChanging(value)
				Me.SendPropertyChanging
				Me._deliverdate = value
				Me.SendPropertyChanged("deliverdate")
				Me.OndeliverdateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_created", DbType:="DateTime NOT NULL", IsDbGenerated:=true)>  _
	Public Property created() As Date
		Get
			Return Me._created
		End Get
		Set
			If ((Me._created = value)  _
						= false) Then
				Me.OncreatedChanging(value)
				Me.SendPropertyChanging
				Me._created = value
				Me.SendPropertyChanged("created")
				Me.OncreatedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="order_item", Storage:="_items", ThisKey:="OrderId", OtherKey:="OrderId")>  _
	Public Property items() As EntitySet(Of item)
		Get
			Return Me._items
		End Get
		Set
			Me._items.Assign(value)
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
	
	Private Sub attach_items(ByVal entity As item)
		Me.SendPropertyChanging
		entity.[order] = Me
	End Sub
	
	Private Sub detach_items(ByVal entity As item)
		Me.SendPropertyChanging
		entity.[order] = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.items")>  _
Partial Public Class item
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ItemId As Integer
	
	Private _OrderId As Integer
	
	Private _code As String
	
	Private _description As String
	
	Private _quantity As Integer
	
	Private _created As Date
	
	Private _order As EntityRef(Of [order])
	
    #Region "可扩展性方法定义"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnItemIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnItemIdChanged()
    End Sub
    Partial Private Sub OnOrderIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnOrderIdChanged()
    End Sub
    Partial Private Sub OncodeChanging(value As String)
    End Sub
    Partial Private Sub OncodeChanged()
    End Sub
    Partial Private Sub OndescriptionChanging(value As String)
    End Sub
    Partial Private Sub OndescriptionChanged()
    End Sub
    Partial Private Sub OnquantityChanging(value As Integer)
    End Sub
    Partial Private Sub OnquantityChanged()
    End Sub
    Partial Private Sub OncreatedChanging(value As Date)
    End Sub
    Partial Private Sub OncreatedChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._order = CType(Nothing, EntityRef(Of [order]))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ItemId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ItemId() As Integer
		Get
			Return Me._ItemId
		End Get
		Set
			If ((Me._ItemId = value)  _
						= false) Then
				Me.OnItemIdChanging(value)
				Me.SendPropertyChanging
				Me._ItemId = value
				Me.SendPropertyChanged("ItemId")
				Me.OnItemIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_OrderId", DbType:="Int NOT NULL")>  _
	Public Property OrderId() As Integer
		Get
			Return Me._OrderId
		End Get
		Set
			If ((Me._OrderId = value)  _
						= false) Then
				If Me._order.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnOrderIdChanging(value)
				Me.SendPropertyChanging
				Me._OrderId = value
				Me.SendPropertyChanged("OrderId")
				Me.OnOrderIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_code", DbType:="VarChar(25) NOT NULL", CanBeNull:=false)>  _
	Public Property code() As String
		Get
			Return Me._code
		End Get
		Set
			If (String.Equals(Me._code, value) = false) Then
				Me.OncodeChanging(value)
				Me.SendPropertyChanging
				Me._code = value
				Me.SendPropertyChanged("code")
				Me.OncodeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_description", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property description() As String
		Get
			Return Me._description
		End Get
		Set
			If (String.Equals(Me._description, value) = false) Then
				Me.OndescriptionChanging(value)
				Me.SendPropertyChanging
				Me._description = value
				Me.SendPropertyChanged("description")
				Me.OndescriptionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_quantity", DbType:="Int NOT NULL")>  _
	Public Property quantity() As Integer
		Get
			Return Me._quantity
		End Get
		Set
			If ((Me._quantity = value)  _
						= false) Then
				Me.OnquantityChanging(value)
				Me.SendPropertyChanging
				Me._quantity = value
				Me.SendPropertyChanged("quantity")
				Me.OnquantityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_created", DbType:="DateTime NOT NULL", IsDbGenerated:=true)>  _
	Public Property created() As Date
		Get
			Return Me._created
		End Get
		Set
			If ((Me._created = value)  _
						= false) Then
				Me.OncreatedChanging(value)
				Me.SendPropertyChanging
				Me._created = value
				Me.SendPropertyChanged("created")
				Me.OncreatedChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="order_item", Storage:="_order", ThisKey:="OrderId", OtherKey:="OrderId", IsForeignKey:=true)>  _
	Public Property [order]() As [order]
		Get
			Return Me._order.Entity
		End Get
		Set
			Dim previousValue As [order] = Me._order.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._order.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._order.Entity = Nothing
					previousValue.items.Remove(Me)
				End If
				Me._order.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.items.Add(Me)
					Me._OrderId = value.OrderId
				Else
					Me._OrderId = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("[order]")
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
