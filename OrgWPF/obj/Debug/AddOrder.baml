   M S B A M L   `   `   `  ����A  =OrgWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:OrgWPFOrgWPF  5   	       OrgWPF.EditWindowOrder   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:OrgWPF     5   	     � Title$  Create/Update order��5   	   $	��600��6%   $	��500��62   .��5	      � -   5         �Name$
 grid��5	      .+�5
   
   �� $/��)Редактирование данных��6   $	��Top=�60   $��Center=�6H   �� 5   
   $��Клиент��6   $	��Top=�6!   $
��Left=�69   $��10,25q�6T   �� 5   
   -   5         ��Name$ ClientID��5      $	��Top=�6h   $
��Left=�6�   $��95,25q�6�   $��20��6�   $	��100��6�   ��6$   ��  �� Path$ ClientID� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��Накладная��6   $	��Top=�6$   $
��Left=�6<   $��10,55q�6W   �� 5   
   -   5        $ Waybill��5      $	��Top=�6k   $
��Left=�6�   $��95,55q�6�   $��20��6�   $	��100��6�   ��6#   �� $ OrderWaybill�$ PropertyChanged=�6�   �� 5   
   $��Дата платежа��6   $	��Top=�6'   $
��Left=�6?   $��10,85q�6Z   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ Data_Payment��5      $��95,85q�6+   $��20��6:   $	��100��6F   $
��Left=�6R   $	��Top=�6m      DisplayDateStart$ 1990.1.1X�6�      Text 6�   �� $ OrderData_Payment�$ PropertyChanged=� �� StringFormat$ {0:yyyy.MM.dd}���� 5   
   $��
Сумма��6   $	��Top=�6    $
��Left=�68   $��10,115q�6S   �� 5   
   -   5        $
 Summ��5      $	��Top=�6e   $
��Left=�6}   $��95,115q�6�   $��20��6�   $	��100��6�   ��6    �� $ 	OrderSumm�$ PropertyChanged=�6�   �� 5   
   $��Состояние��6   $	��Top=�6$   $
��Left=�6<   $��10,145q�6W   �� 5   
   -   5        $ 	Condition��5      $	��Top=�6o   $
��Left=�6�   $��95,145q�6�   $��20��6�   $	��100��6�   ��6%   �� $ OrderCondition�$ PropertyChanged=�6�   �� 5   
   $��Дата отгрузки��6   $	��Top=�6(   $
��Left=�6@   $��10,175q�6[     5   
   -   5        $ Data_Shipment��5      $��95,175q�6,   $��20��6<   $	��100��6H   $
��Left=�6T   $	��Top=�6o   	   DisplayDate$	 1990/1/1��6�    6�   �� $ OrderData_Shipment�$ PropertyChanged=�$ {0:yyyy.MM.dd}���� 5   
   $��Примечание��6   $	��Top=�6%   $
��Left=�6=   $��10,205q�6X   �� 5   
   -   5        $
 Note��5      $	��Top=�6e   $
��Left=�6}   $��95,205q�6�   $��20��6�   $	��100��6�   ��6    �� $ 	OrderNote�$ PropertyChanged=�6�   �� 5   
   -	   5        
 ��Name$
 btnOK��5      $��30��6    $��40��6,   $��OK��67   $��10,235q�6D   $	��Top=�6T   $
��Left=�6l   6�   �� 5   
   -
   5        $
 	btnCancel��5      $��30��6$   $��40��60   $��Cancel��6;   $��80,235q�6L   $	��Top=�6\   $
��Left=�6t   6�   5      5      