   M S B A M L   `   `   `  ����A  =OrgWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:OrgWPFOrgWPF  5   	       OrgWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:OrgWPF     5   	     � Title$	  Org��5   	   $	��800��6   $	��900��6"   .��5	      �  � RowDefinitions 5
   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $	��200 �6   �� 5      $��40 �6   .+�5   
   � $��0��6   .+�5      �� $��Choose the Organization��6   $��10,10q�67   $��20��6F   $	��140��6R   $
��Left=�6^   $	��Top=�6y   �� 5      -   5         ��Name$ OrgBox��5      $��10,10q�6'   $��20��66   $	��200��6B   $	��Top=�6N   $
��Left=�6f    �� DisplayMemberPath$ OrgName��6�    �� SelectedValuePath$ OrgID��6�    �� SelectedIndex$ 0��6�   ��6�   �� 6�   �� 5      -   5         ��Name$ AddOrg��5      $��Add Organization��6%   $��20��6@   $	��120��6L   $��10,10q�6X   $	��Top=�6g   $
��Left=�6   6�   �� 5      -   5        $ 	DeleteOrg��5      $��Delete Organization��6(   $��20��6F   $	��120��6R   $��10,10q�6^   $	��Top=�6m   $
��Left=�6�   6�   �� 5      -   5        $ 	UpdateOrg��5      $��Update Organization��6(   $��20��6F   $	��120��6R   $��10,10q�6^   $	��Top=�6m   $
��Left=�6�   6�   5      � 5   
   $��1��6   .+�5      �� $��Choose the Client��6   $��10,10q�61   $��20��6@   $	��140��6L   $
��Left=�6X   $	��Top=�6s   �� 5      -   5        $ 	ClientBox��5      $��10,10q�6*   $��20��69   $	��200��6E   $	��Top=�6Q   $
��Left=�6i   $ ClientManager��6�   $ ClientID��6�   $ 0��6	  ��6�   ��  �� ElementName$ OrgBox�� �� Path$ SelectedItem.Clients�6  �� 5      -   5        $ 	AddClient��5      $��
Add Client��6(   $��20��6=   $	��120��6I   $��10,10q�6U   $	��Top=�6d   $
��Left=�6|   6�   �� 5      -   5        $ DeleteClient��5      $��Delete Client��6+   $��20��6C   $	��120��6O   $��10,10q�6[   $	��Top=�6j   $
��Left=�6�   6�   �� 5      -   5        $ UpdateClient��5      $��Update Client��6+   $��20��6C   $	��120��6O   $��10,10q�6[   $	��Top=�6j   $
��Left=�6�   6�   5      � 5   
   $��2��6   .+�5       �� $��Choose the Order��6   $��10,10q�60   $��20��6?   $	��140��6K   $
��Left=�6W   $	��Top=�6r   �� 5!      -	   5        $ OrderBox��5!      $��10,10q�6)   $��20��68   $	��200��6D   $	��Top=�6P   $
��Left=�6h   $ OrderWaybill��6�   $ OrderID��6�   $ 0��6  ��6�   �� $ 	ClientBox��$ SelectedItem.Orders�6  �� 5"      -
   5        $ AddOrder��5"      $��	Add Order��6'   $��20��6;   $	��120��6G   $��10,10q�6S   $	��Top=�6b   $
��Left=�6z   6�   �� 5#      -   5        $ DeleteOrder��5#      $��Delete Order��6*   $��20��6A   $	��120��6M   $��10,10q�6Y   $	��Top=�6h   $
��Left=�6�   6�   �� 5$      -   5        $ UpdateOrder��5$      $��Update Order��6*   $��20��6A   $	��120��6M   $��10,10q�6Y   $	��Top=�6h   $
��Left=�6�   6�   5%      � 5&   
   $��3��6   .+�5'      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 PaymentGrid��5'      $��1��6,   
   RowHeaderWidth$
 50Q�6�      AutoGenerateColumns .  $
��Auto=�6�      
IsReadOnly . ��6<   �� $ OrderBox��$ SelectedItem.Payments�   Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ Дата платежа��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6~   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *PaymentData+ �� StringFormat$ {0:yyyy.MM.dd}��   	CellStyle 5*      �� 5+      .�5,   "   ��  �� Property �@��TextAlignment �� Value$ Right=�6L   5-      5/        50      $ Количество��6)   $ * 6_    6=   �� *PaymentNumber+ 51      �� 52      .�53   "   ��  �@��TextAlignment$ Right=�6L   54      56        57      $ 
Сумма��6)   $ * 6X    68   �� *PaymentSumm+ 58      �� 59      .�5:   "   ��  �@��TextAlignment$ Right=�6L   5;      5=        5>      $ Код банка��6)   $ * 6a    6<   �� *PaymentBank_Code+ 5?      �� 5@      .�5A   "   ��  �@��TextAlignment$ Right=�6L   5B      5D      5F      5G      � 5H   
   $��4��6   .+�5I      �� -   5        $ 
AddPayment��5I      $��Add Payment��6)   $��20��6?   $	��120��6K   $��10,10q�6W   $	��Top=�6f   $
��Left=�6~   6�   �� 5J      -   5        $ DeletePayment��5J      $��Delete Payment��6,   $��20��6E   $	��120��6Q   $��10,10q�6]   $	��Top=�6l   $
��Left=�6�   6�   �� 5K      -   5        $ UpdatePayment��5K      $��Update Payment��6,   $��20��6E   $	��120��6Q   $��10,10q�6]   $	��Top=�6l   $
��Left=�6�   6�   5L      5N      5O      