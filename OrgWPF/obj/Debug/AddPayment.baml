   M S B A M L   `   `   `  ����A  =OrgWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:OrgWPFOrgWPF  5   	       OrgWPF.EditWindowPayment   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:OrgWPF     5   	     � Title$  
AddPayment��5   	   $	��800��6   $	��300��6)   .��5	      � -   5         �Name$
 grid��5	      .+�5
   
   �� $/��)Редактирование данных��6   $	��Top=�60   $��Center=�6H   �� 5   
   $��
Заказ��6   $	��Top=�6    $
��Left=�68   $��10,25q�6S   �� 5   
   -   5         ��Name$ OrderID��5      $	��Top=�6f   $
��Left=�6~   $��95,25q�6�   $��20��6�   $	��100��6�   ��6#   ��  �� Path$ OrderID� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��Дата��6   $	��Top=�6   $
��Left=�67   $��10,55q�6R   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ PaymentData��5      $��95,55q�6*   $��20��69   $	��100��6E   $
��Left=�6Q   $	��Top=�6l      DisplayDateStart$ 1990.1.1X�6�      Text 6�   �� $ PaymentData�$ PropertyChanged=� �� StringFormat$ {0:yyyy.MM.dd}���� 5   
   $��Количество��6   $	��Top=�6%   $
��Left=�6=   $��10,85q�6X   �� 5   
   -   5        $ PaymentNumber��5      $	��Top=�6r   $
��Left=�6�   $��95,85q�6�   $��20��6�   $	��100��6�   ��6)   �� $ PaymentNumber�$ PropertyChanged=�6�   �� 5   
   $��
Сумма��6   $	��Top=�6    $
��Left=�68   $��10,115q�6S   �� 5   
   -   5        $ PaymentSumm��5      $	��Top=�6n   $
��Left=�6�   $��95,115q�6�   $��20��6�   $	��100��6�   ��6'   �� $ PaymentSumm�$ PropertyChanged=�6�   �� 5   
   $��Код Банка��6   $	��Top=�6$   $
��Left=�6<   $��10,145q�6W   �� 5   
   -   5        $ PaymentBank_Code��5      $	��Top=�6x   $
��Left=�6�   $��95,145q�6�   $��20��6�   $	��100��6�   ��6,   �� $ PaymentBank_Code�$ PropertyChanged=�6�   �� 5   
   -   5        	 ��Name$	 btnOK��5      $��30��6    $��40��6,   $��OK��67   $��10,235q�6D   $	��Top=�6T   $
��Left=�6l   6�   �� 5   
   -   5        $	 	btnCancel��5      $��30��6$   $��40��60   $��Cancel��6;   $��80,235q�6L   $	��Top=�6\   $
��Left=�6t   6�   5      5      