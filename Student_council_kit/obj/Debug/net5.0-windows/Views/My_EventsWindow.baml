   M S B A M L   `   `   `  ????N  JStudent_council_kit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Student_council_kit.ViewsStudent_council_kit.Views  5   	   /    )Student_council_kit.Views.My_EventsWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Student_council_kit.Views     5   	     ? Title$#  Мои мероприятия??5   	   $	??750??6!   $
??1000??6.   $
??1000??6;   $	??750??6K   $	??800??6[   $	??600??6k    ? WindowStartupLocation$ CenterScreen=?6z   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $	??64* ?6   ?? 5      $
??303* ?6   .+?5   
   ??  ?? Orientation$ 
Horizontal=?6   $
??Left=?6.   $	??Top=?6I   $	??128??6a   $
??1000??6n   ???#1C1594.+?5      ?? $??..\Resources\logo.png??6   $??30 0 0 0q?63   6G   5      ?? 5   
   -   5         ??Name$ btn_exit??5   !   $??
Назад??6      button_exit#??[  6J   6q   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGridDirection??5      $??1??6+     	data_grid#??[ 68      AutoGenerateColumns$ False??6[      
IsReadOnly$
 True??6w   $??	0,100,0,0q?6?   $	??420??6?      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$-	 'Название мероприятия??6%   -   5        column_name??
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 250 5   X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6d   ?? *
Event.Name+6?     5      $#	 Дата проведения??6%   $	
 250 6>   -   5        column_date?? 5   _   ?? *
Event.Date+6?   5      5      5      