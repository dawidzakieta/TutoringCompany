   M S B A M L   `   `   `  ����M  ITutoringCompanyGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TutoringCompanyGUITutoringCompanyGUI  5      7 clr-namespace:TutoringCompanyGUITutoringCompanyGUI  5      "    TutoringCompanyGUI.AddLesson   5      (src clr-namespace:TutoringCompanyGUI  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      2local clr-namespace:TutoringCompanyGUI     5        � Title$  	AddLesson��5	      $	��566��6#   $	��600��60    � 
ResizeMode$ CanMinimize=�6<    � WindowStyle$
 None=�5
       � AllowsTransparency .  � 	Resources 5       �� 
TargetType �� Property   
Background �� Value  
SmallLabel �� BasedOn  TextBox  ComboBox  MainButtons  AddLessonTemplate	 �� Orientation
 �� StringFormat �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ Styles.xaml?�6%   �� 5      $ TitleGrid.xaml?�6%   %W  '�       7   '�� D     7  '�� f     7  '�� �     7  '�� �     7  &	 �     �� 5      " �6   .�5      ��  � ��8   6/   5      �� 5      " ��6   8   6'   �� 5      " ��6   8   6)   �� 5      " ��6   8   6*   �� 5      " ��6   8   6(   �� 5      .R�5      �� $��0,3,0,0q�6   .+�5      �� $	 
Horizontal=�6!   .+�5      �� $
��Bold"�6P   $��
0, 0, 5, 0q�6b   ��6$   �� *Id+$
 ID: {0}��6b   �� 5      $��
0, 0, 5, 0q�6:   ��6$   �� *Name+6:   �� 5      ��6$   �� *	Surname+5      5      5      5!      .��5#      �  � RowDefinitions 5$   
   �� 5%      $
��Auto �6   �� 5&      $	��30* �6   .+�5(   
   �� -   5         ��Name$ TitleContent��5(        	TitleGrid#��[ 6/   � 5)   
   $��1��6   .+�5,      �� -   5         ��Name$ lessonStudent��5,      $
��Left=�6.   $��
200,80,0,0q�6I   $	��Top=�5-   0   $	��300��6H   $��40��6T   $��18(�6`   #��[ 5.       �� SelectedItem 5-      �� *	Student+5.      �� 5/      -   5         ��Name$ 
lessonDate��5/      $
��Left=�6*   $��200,200,0,0q�6E   $	��Top=�6Z   $	��300��6r   $��40��6~   �� 50      -   5        $ 
lessonTime��50      $
��Left=�6*   $��200,320,0,0q�6E   $	��Top=�6[   $	��300��6s   $��40��6   �� 52      $��Student��6   $
��Left=�6*   $��	80,80,0,0q�6E   $	��Top=�6X   �� 53      $
��Date��6   $
��Left=�6(   $��
80,200,0,0q�6C   $	��Top=�6W   �� 54      $
��Time��6   $
��Left=�6(   $��
80,320,0,0q�6C   $	��Top=�6W   �� 56      -   5         ��Name$ 	addLesson��56      $��
Add Lesson��6(   $��
80,450,0,0q�6>   $
��Left=�6R   $	��419��6m   6y   57      58      59      