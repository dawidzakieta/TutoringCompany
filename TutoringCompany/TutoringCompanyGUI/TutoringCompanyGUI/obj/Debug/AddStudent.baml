   M S B A M L   `   `   `  ����M  ITutoringCompanyGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TutoringCompanyGUITutoringCompanyGUI  5      7 clr-namespace:TutoringCompanyGUITutoringCompanyGUI  5      #    TutoringCompanyGUI.AddStudent   5      (src clr-namespace:TutoringCompanyGUI  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      2local clr-namespace:TutoringCompanyGUI     5        � Title$  
AddStudent��5	      $	��566��6$   $	��600��61    � 
ResizeMode$ CanMinimize=�6=    � WindowStyle$
 None=�5
       � AllowsTransparency .  � 	Resources 5       �� 
TargetType �� Property   
Background �� Value  
SmallLabel �� BasedOn  TextBox  ComboBox  MainButtons  AddStudentTemplate	 �� Orientation
 �� StringFormat �� MergedDictionaries �� Source�� 5   
    5!      �� 5"      $ Styles.xaml?�6%   �� 5#      $ TitleGrid.xaml?�6%   %W  '�       7   '�� D     7  '�� f     7  '�� �     7  '�� �     7  &	 �     �� 5      " �6   .�5      ��  � ��8   6/   5      �� 5      " ��6   8   6'   �� 5      " ��6   8   6)   �� 5      " ��6   8   6*   �� 5      " ��6   8   6(   �� 5      .R�5      �� $��0,3,0,0q�6   .+�5      �� $	 
Horizontal=�6!   .+�5      �� $
��Bold"�6P   $��
0, 0, 5, 0q�6b   ��6$   �� *Id+$
 ID: {0}��6b   �� 5      $��
0, 0, 5, 0q�6:   ��6$   �� *Name+6:   �� 5      ��6$   �� *	Surname+5      5      5      5'      .��5)      �  � RowDefinitions 5*   
   �� 5+      $
��Auto �6   �� 5,      $	��30* �6   .+�5.   
   �� -   5         ��Name$ TitleContent��5.        	TitleGrid#��[ 6/   � 5/   
   $��1��6   .+�51      �� -   5         ��Name$ studentName��51      $
��Left=�6+   $��
200,21,0,0q�6F   $	��Top=�6Z   $	��300��6r   $��40��6~   �� 52      -   5        $ studentSurname��52      $
��Left=�6.   $��
200,82,0,0q�6I   $	��Top=�6]   $	��300��6u   $��40��6�   �� 53      -   5        $ studentPhone��53      $
��Left=�6,   $��200,143,0,0q�6G   $	��Top=�6\   $	��300��6t   $��40��6�   �� 55      -   5         ��Name$ studentClient��55      $
��Left=�6.   $��200,204,0,0q�6I   $	��Top=�56   /   $	��300��6G   $��40��6S   $��18(�6_   #��[ 57       �� SelectedItem 56      �� *Client+57      �� 59      -   5        $ studentTutor��59      $
��Left=�6-   $��200,265,0,0q�6H   $	��Top=�5:   .   $	��300��6F   $��40��6R   $��18(�6^   #��[ 5;       5:      �� *Tutor+5;      �� 5=      -   5        $ studentClass��5=      $
��Left=�6-   $��200,326,0,0q�6H   $	��Top=�6]   $	��300��6u   $��40��6�    6�   �� *Class+@�5>      �� 5?      $��Kindergarten��6#   �� 5@      $��PrimarySchool1��6#   �� 5A      $��PrimarySchool2��6#   �� 5B      $��PrimarySchool3��6#   �� 5C      $��PrimarySchool4��6#   �� 5D      $��PrimarySchool5��6#   �� 5E      $��PrimarySchool6��6#   �� 5F      $��PrimarySchool7��6#   �� 5G      $��PrimarySchool8��6#   �� 5H      $��HighSchool1��6#   �� 5I      $��HighSchool2��6#   �� 5J      $��HighSchool3��6#   �� 5K      $��HighSchool4��6#   �� 5L      $��TechnicalSchool1��6#   �� 5M      $��TechnicalSchool2��6#   �� 5N      $��TechnicalSchool3��6#   �� 5O      $��TechnicalSchool4��6#   �� 5P      $��TechnicalSchool5��6#   �� 5Q      $��
University��6#   5S      �� 5T      -   5        $ studentGender��5T      $
��Left=�6.   $��200,387,0,0q�6I   $	��Top=�6^   $	��300��6v   $��40��6�    6�   �� *Gender+@�5U      �� 5V      $
��Male��6#   �� 5W      $��Female��6#   �� 5X      $��Other��6#   5Z      �� 5\      $
��Name��6   $
��Left=�6)   $��	80,21,0,0q�6D   $	��Top=�6X   �� 5]      $��Surname��6   $
��Left=�6)   $��	80,82,0,0q�6D   $	��Top=�6X   �� 5^      $��Phone��6   $
��Left=�6)   $��
80,143,0,0q�6D   $	��Top=�6X   �� 5_      $��Client��6   $
��Left=�6)   $��
80,204,0,0q�6D   $	��Top=�6X   �� 5`      $��Tutor��6   $
��Left=�6)   $��
80,265,0,0q�6D   $	��Top=�6X   �� 5a      $��Class��6   $
��Left=�6)   $��
80,326,0,0q�6D   $	��Top=�6X   �� 5b      $��Gender��6   $
��Left=�6)   $��
80,387,0,0q�6D   $	��Top=�6X   �� 5d      -	   5         ��Name$ addStudent2��5d      $��Add Student��6*   $��
80,450,0,0q�6A   $
��Left=�6U   $	��419��6p   6|   5e      5f      5g      