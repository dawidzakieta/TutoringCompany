   M S B A M L   `   `   `  ����M  ITutoringCompanyGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TutoringCompanyGUITutoringCompanyGUI  5      7 clr-namespace:TutoringCompanyGUITutoringCompanyGUI  5      !    TutoringCompanyGUI.AddTutor   5      (src clr-namespace:TutoringCompanyGUI  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      2local clr-namespace:TutoringCompanyGUI     5        � Title$  AddTutor��5	      $	��566��6"   $	��600��6/    � 
ResizeMode$ CanMinimize=�6;    � WindowStyle$
 None=�5
       � AllowsTransparency .  � 	Resources 5       �� 
TargetType �� Property   
Background �� Value  
SmallLabel �� BasedOn  TextBox  ComboBox  MainButtons	 �� MergedDictionaries
 �� Source�� 5   
   	 5      �� 5      $
 Styles.xaml?�6%   �� 5      $
 TitleGrid.xaml?�6%   %  '�       7   '�� D     7  '�� f     7  '�� �     7  '�� �     7  �� 5      " �6   .�5      ��  � ��8   6/   5      �� 5      " ��6   8   6'   �� 5      " ��6   8   6)   �� 5      " ��6   8   6*   �� 5      " ��6   8   6(   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $	��30* �6   .+�5   
   �� -   5         ��Name$ TitleContent��5        	TitleGrid#��[ 6/   � 5    
   $��1��6   .+�5!      �� -   5         ��Name$ 	tutorName��5!      $
��Left=�6-   $��
200,30,0,0q�6H   $	��Top=�6]   $	��300��6u   $��40��6�   �� 5"      -   5        $ tutorSurname��5"      $
��Left=�6-   $��200,100,0,0q�6H   $	��Top=�6]   $	��300��6u   $��40��6�   �� 5#      -   5        $ 
tutorPhone��5#      $
��Left=�6-   $��200,170,0,0q�6H   $	��Top=�6]   $	��300��6u   $��40��6�   �� 5$      -   5        $ 
tutorEmail��5$      $
��Left=�6-   $��200,240,0,0q�6H   $	��Top=�6]   $	��300��6u   $��40��6�   �� 5%      -   5        $ 	tutorRate��5%      $
��Left=�6-   $��200,310,0,0q�6H   $	��Top=�6]   $	��300��6u   $��40��6�   �� 5&      -   5         ��Name$ tutorGender��5&      $
��Left=�6-   $��200,380,0,0q�6H   $	��Top=�6]   $	��300��6u   $��40��6�    �� SelectedItem 6�   �� *Gender+@�5'      �� 5(      $
��Male��6#   �� 5)      $��Female��6#   �� 5*      $��Other��6#   5,      �� 5-      $
��Name��6   $
��Left=�6)   $��	80,30,0,0q�6D   $	��Top=�6X   $	��100��6p   $��40��6|   �� 5.      $��Surname��6   $
��Left=�6)   $��
80,100,0,0q�6D   $	��Top=�6X   $	��100��6p   $��40��6|   �� 5/      $��Phone��6   $
��Left=�6)   $��
80,170,0,0q�6D   $	��Top=�6X   $	��100��6p   $��40��6|   �� 50      $��Email��6   $
��Left=�6)   $��
80,240,0,0q�6D   $	��Top=�6X   $	��100��6p   $��40��6|   �� 51      $��	Hour rate��6   $
��Left=�6)   $��
80,310,0,0q�6D   $	��Top=�6X   $	��100��6p   $��40��6|   �� 52      $��Gender��6   $
��Left=�6)   $��
80,380,0,0q�6D   $	��Top=�6X   $	��100��6p   $��40��6|   �� 53      -   5         ��Name$ addTutor��53      $��	Add Tutor��6'   $��
80,450,0,0q�6D   $
��Left=�6X   $	��419��6s   6   54      55      56      