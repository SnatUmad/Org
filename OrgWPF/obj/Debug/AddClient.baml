   M S B A M L   `   `   `  ����
  OrgWPF    OrgWPF.EditWindowClient   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   >d2http://schemas.microsoft.com/expression/blend/2008    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Create/Update client��5   	   $	��500��6&   $	��300��63   .��5      � -   5         �Name$
 grid��5      .+�5	   
   �� $/��)Редактирование данных��6   $	��Top=�60   $��Center=�6H   �� 5
   
   $��Менеджер��6   $	��Top=�6#   $
��Left=�6;   $��10,25q�6V   �� 5   
   -   5         ��Name$ Manager��5      $	��Top=�6l   $
��Left=�6�   $��95,25q�6�   $��20��6�   $	��100��6�   ��6#   ��  �� Path$ ClientManager� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��Телефон��6   $	��Top=�6"   $
��Left=�6:   $��10,55q�6U   �� 5   
   -   5        $ Phone��5      $	��Top=�6h   $
��Left=�6�   $��95,55q�6�   $��20��6�   $	��100��6�   ��6!   �� $ ClientPhone�$ PropertyChanged=�6�   �� 5   
   $��Организация��6   $	��Top=�6&   $
��Left=�6>   $��10,85q�6Y   �� 5   
   -   5        $ OrgID��5      $	��Top=�6b   $
��Left=�6z   $��95,85q�6�   $��20��6�   $	��100��6�   ��6!   �� $ OrgID�$ PropertyChanged=�6�   �� 5   
   -   5         ��Name$ btnOK��5      $��30��6    $��40��6,   $��OK��67   $��10,205q�6D   $	��Top=�6T   $
��Left=�6l   6�   �� 5   
   -   5        $ 	btnCancel��5      $��30��6$   $��40��60   $��Cancel��6;   $��80,205q�6L   $	��Top=�6\   $
��Left=�6t   6�   5      5      