   M S B A M L   `   `   `  ����M  ITutoringCompanyGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TutoringCompanyGUITutoringCompanyGUI  5      7 clr-namespace:TutoringCompanyGUITutoringCompanyGUI  5      "    TutoringCompanyGUI.AddClient   5      (src clr-namespace:TutoringCompanyGUI  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      2local clr-namespace:TutoringCompanyGUI     5        � Title$  	AddClient��5	      $	��566��6#   $	��600��60    � 
ResizeMode$ CanMinimize=�6<    � WindowStyle$
 None=�5
       � AllowsTransparency .  � 	Resources 5       �� 
TargetType �� Property   
Background �� Value  
SmallLabel �� BasedOn  TextBox  ComboBox  MainButtons	 �� MergedDictionaries
 �� Source�� 5   
   	 5!      �� 5"      $
 Styles.xaml?�6%   �� 5#      $
 TitleGrid.xaml?�6%   %H  '�       7   '�� D     7  '��     7  '�� �    7  '�� �    7  �� 5      " �6   .�5      ��  � ��8   6/   5      �� 5      " ��6   8   .�5      ��  � ��$	 Top=�66   �� 5       � ��$
 Left=�68   �� 5       � ��$ 40��6+   �� 5       � ��$	 100��6*   5      �� 5      " ��6   8   .�5      ��  � ��$	 Top=�66   �� 5       � ��$
 Left=�68   �� 5       � ��$ 40��6+   �� 5       � ��$	 300��6*   5      �� 5      " ��6   8   6*   �� 5      " ��6   8   6(   5%      .��5'      �  � RowDefinitions 5(   
   �� 5)      $
��Auto �6   �� 5*      $	��30* �6   .+�5,   
   �� -   5         ��Name$ TitleContent��5,        	TitleGrid#��[ 6/   � 5-   
   $��1��6   .+�5.      �� -   5         ��Name$ 
clientName��5.      $��
200,30,0,0q�6-   �� 5/      -   5        $ clientSurname��5/      $��200,100,0,0q�6-   �� 50      -   5        $ clientPhone��50      $��200,170,0,0q�6-   �� 51      -   5        $ clientEmail��51      $��200,240,0,0q�6-   �� 52      -   5        $ 
clientRate��52      $��200,310,0,0q�6-   �� 53      -   5         ��Name$ clientGender��53      $��200,380,0,0q�6-   $
��Left=�6b   $	��Top=�6~   $	��300��6�   $��40��6�    �� SelectedItem 6B   �� *Gender+@�54      �� 55      $
��Male��6#   �� 56      $��Female��6#   �� 57      $��Other��6#   59      �� 5:      $
��Name��6   $��	80,30,0,0q�6)   �� 5;      $��Surname��6   $��
80,100,0,0q�6)   �� 5<      $��Phone��6   $��
80,170,0,0q�6)   �� 5=      $��Email��6   $��
80,240,0,0q�6)   �� 5>      $��	Hour rate��6   $��
80,310,0,0q�6)   �� 5?      $��Gender��6   $��
80,380,0,0q�6)   �� 5@      -   5         ��Name$ 
addClient2��5@      $��
80,450,0,0q�6)   $��
Add Client��6=   #��[ 6k   $
��Left=�6�   $	��419��6�   5A      5B      5C      