   M S B A M L   `   `   `  ����N  JWixWPF, Version=3.10.0.0, Culture=neutral, PublicKeyToken=8665a3a8c7e50284/$clr-namespace:WixWPF;assembly=WixWPFWixWPF  5       	WixWPFUI1   WixWPFUI1.MainWindow   5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      2mba$clr-namespace:WixWPF;assembly=WixWPF    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5      >d2http://schemas.microsoft.com/expression/blend/2008    5        � Title$  WixWPFUI1 Installer��5      $	��200��5      $	��400��6    � 
ResizeMode$ NoResize=�6     � 	Resources 5
      $   WixWPF.ConvertBoolToVisibility   	BoolToVis  BoolToVisNeg   	TrueValue   
FalseValue��%]   &	        &	        5      6      5      $ 	Collapsed=�65   $ Visible=�6K   5      .��5      � -   5         �Name$ 
LayoutRoot��5       � RowDefinitions 5      �� 5      $��20 �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��20 �6   .+�5      �� $��1��6    �� Orientation$ 
Horizontal=�6   $��Center=�65   .+�5      �� $��1��6   $��50��6   $#��/WixWPFUI1;component/Logo.png��6'   $��Uniform=�6N   �� 5      $��1��6   $��	WixWPFUI1��6   $��10,0,0,0q�6-   $��24(�6?   $��Center=�6M   5      �� 5      $��4��6   $ 
Horizontal=�6   $��Center=�65    5       �� 
TargetType	 �� Property
 �� Value��%x   '��       �� 5      " ��6   .�5      �� 	 � ��$	
 6,0q�6    �� 5      	 � ��$	
 4,2q�6!   5       5!      .+�5"      �� -   5         ��Name$ ButtonInstall��5"      $��Install��6#   {�65   �� *
CanInstall+6V   �� 5#      -   5        $ ButtonUninstall��5#      $��	Uninstall��6%   {�69   �� *IsInstalled+6[   �� 5$      -   5        $ 
ButtonQuit��5$      $
��Quit��6    6/   5%      �� 5&      $��0��6   $��6��6   y�6)   �� *IsBusy+ �� 	Converter# [  .+�5'      ��  �� Left$ 0��6   
 �� Top$ 0��6   
���   � J� Opacity$
 0.75Q�6�   ��6+   ��  �� ElementName$ 
LayoutRoot�� �� Path$ ActualHeight���6h   �� $ 
LayoutRoot��$ ActualWidth�6�   � 5(      $ 0��6
   $ 0��6   ��6)   �� $ 
LayoutRoot��$ ActualHeight���6f   �� $ 
LayoutRoot��$ ActualWidth�.+�5)      �� $��Center=�6)   $��Center=�6D   $��0,15,0,0q�6a   ��6   �� *	Message+6a   � 5*       � IsIndeterminate . $��10��6)   $��0,55,0,0q�65   5+      5,      5-      5.      