   M S B A M L   `   `   `  ????N  JStudent_council_kit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Student_council_kit.ViewsStudent_council_kit.Views  5   	   7    1Student_council_kit.Views.Events_DirectionsWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Student_council_kit.Views     5   	     ? Title$3  -Мероприятия направления??5   	   $	??750??6)   $
??1000??66   $
??1000??6C   $	??750??6S   $	??800??6c   $	??600??6s    ? WindowStartupLocation$ CenterScreen=?6?   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $	??64* ?6   ?? 5      $
??303* ?6   .+?5   
   ??  ?? Orientation$ 
Horizontal=?6   $
??Left=?6.   $	??Top=?6I   $	??128??6a   $
??1000??6n   ???#1C1594.+?5      ?? $??..\Resources\logo.png??6   $??30 0 0 0q?63   6G   5      ?? 5   
   -   5         ??Name$ btn_exit??5   !   $??
Назад??6      button_exit#??[  6J   6q   ?? 5      $??1??6   $	??Top=?6%   $	??400??6=   $??30??6I   $??0 10 0 0q?6U   6i   ?? 5   
   $??1??6   $	??400??6"   $	??500??6.   $
??Left=?6;   $??30 0 0 0q?6V   .+?5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgrid_events??5         SelectionMode$ Single=?6f      AutoGenerateColumns$ False??6}   $??1??6?   $??1??6?      CanUserResizeRows$ False??6?   	   CanUserResizeColumns$	 False??6?   $
   HorizontalScrollBarVisibility$
 Hidden=?6?      
IsReadOnly$
 True??6     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$- 'Название пероприятия??6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 250 6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   ?? *Name+6n   5      5      ?? 5   
   $??1??6   $
??Left=?6"   $	??Top=?6=   $	??500??6U   $	??386??6a   $??
490 55 0 0q?6n   $ Vertical=?6?   .+?5      ?? -   5         ??Name$ tblock_name??5   $   $??35??6     textblock_event#??[ 69   $
??Wrap=?6b   $	??498??6w   6?   ?? 5      $??35??6   $??Описание:??6$   #??[ 65   $	??498??6^   6l   ?? 5      -   5        $ tblock_description??5   %   $	??170??6   $??0 15 0 0q?6A   $
??Wrap=?6S   #??[ 6g   $	??499??6?   6?   ?? 5      $??31??6   $ 
Horizontal=?6%   .+?5      ?? $$??Дата проведения:??6   $??31??64   $	??Top=?6@   #??[ 6X   $	??203??6?   6?   ?? 5       -   5        $ tblock_date??5    4   $	??296??6   $??29??6(   $	??Top=?6I   #??[ 6a   6?   5!      ?? 5"      $ 
Horizontal=?6   $	??Top=?62   .+?5#      ?? $	??100??6   $??Статус:??6(   #??[ 67   6b   ?? 5$      -   5        $ tblock_status??5$   (   $	??396??6   #??[ 6?   6j   5%      ?? 5&      -   5        $ 
btn_enroll??5&   -   $	??130??6   $??40??6!   $??Записаться??6Z   $
??Left=?6o   $??0 15 0 0q?6?    
 button#??[ 6?    ? 	Resources 5'       ?? 
TargetType ?? Property ?? Value??%c   '??       ?? 5(      " ??6   .?5)      ??  ?@??CornerRadius$ 5??69   6E   5*      5+      5,      5-      5.      5/      