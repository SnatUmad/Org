   M S B A M L   `   `   `  ����A  =OrgWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:OrgWPFOrgWPF  5   	       OrgWPF.EditWindowOrg   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:OrgWPF     5   	     � Title$   Create/Update organization��5   	   $	��500��6,   $	��300��69   .��5	      � -   5         �Name$
 grid��5	      .+�5
   
   �� $/��)Редактирование данных��6   $	��Top=�60   $��Center=�6H   �� 5   
   $��УНП��6   $	��Top=�6   $
��Left=�66   $��10,25q�6Q   �� 5   
   -   5         ��Name$	 YNP��5      $	��Top=�6a   $
��Left=�6y   $��95,25q�6�   $��20��6�   $	��100��6�   ��6   ��  �� Path$ OrgYNP� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��Название��6   $	��Top=�6#   $
��Left=�6;   $��10,55q�6V   �� 5   
   -   5        $
 Name��5      $	��Top=�6c   $
��Left=�6{   $��95,55q�6�   $��20��6�   $	��100��6�   ��6    �� $ OrgName�$ PropertyChanged=�6�   �� 5   
   $��Менеджер��6   $	��Top=�6#   $
��Left=�6;   $��10,85q�6V   �� 5   
   -   5        $ Manager��5      $	��Top=�6i   $
��Left=�6�   $��95,85q�6�   $��20��6�   $	��100��6�   ��6#   �� $ 
OrgManager�$ PropertyChanged=�6�   �� 5   
   $��
Адрес��6   $	��Top=�6    $
��Left=�68   $��10,115q�6S   �� 5   
   -   5        $ Adress��5      $	��Top=�6g   $
��Left=�6   $��95,115q�6�   $��20��6�   $	��100��6�   ��6"   �� $ 	OrgAdress�$ PropertyChanged=�6�   �� 5   
   $��Телефон��6   $	��Top=�6"   $
��Left=�6:   $��10,145q�6U   �� 5   
   -   5        $ Phone��5      $	��Top=�6e   $
��Left=�6}   $��95,145q�6�   $��20��6�   $	��100��6�   ��6!   �� $ OrgPhone�$ PropertyChanged=�6�   �� 5   
   $��Факс��6   $	��Top=�6   $
��Left=�67   $��10,175q�6R   �� 5   
   -   5        $	 Fax��5      $	��Top=�6a   $
��Left=�6y   $��95,175q�6�   $��20��6�   $	��100��6�   ��6   �� $ OrgFax�$ PropertyChanged=�6�   �� 5   
   -   5         ��Name$ btnOK��5      $��30��6    $��40��6,   $��OK��67   $��10,205q�6D   $	��Top=�6T   $
��Left=�6l   6�   �� 5   
   -	   5        $ 	btnCancel��5      $��30��6$   $��40��60   $��Cancel��6;   $��80,205q�6L   $	��Top=�6\   $
��Left=�6t   6�   5      5      