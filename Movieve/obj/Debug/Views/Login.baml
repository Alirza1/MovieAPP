   M S B A M L   `   `   `  ????B  >Movieve, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Movieve.ViewsMovieve.Views  5   	       Movieve.Views.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Movieve.Views     5   	   -   5          ?Name$  
LoginPanel??5   	    ? Title$ Login??5      $	??800??6(   $
??1200??65    ? WindowStartupLocation$ CenterScreen=?6B    ? 
ResizeMode$ NoResize=?6g   .??5
      ? .+?5   
   ?? -   5         ??Name$ panelBorder??5      
???   ? J? Opacity$	 0.7Q?69   $??297,226,283,215q?6G    ?? CornerRadius$ 15??6`   $??2q?6r   ._?5      ? .+?5      ?? $??ImageFiles\account.png??6   $??46,69,510,186q?68   ?? 5      $??ImageFiles\password.png??6   $??46,163,510,100q?69   ?? 5      -   5        $??UsernameEmailTextBox??5      
??????? ?? 	MaxLength$ 20??6I   $??135,69,180,199q?6r   $??25(?6?    ?? TextWrapping$
 Wrap=?6?   ??6X   ?? *
Username+6?   ?? 5      -   5        $??PasswordBoxx??5      $ 16??6.   
???????$??135,171,180,107q?6j   $??25(?6?   ??6=   ?? *
Password+6?   ?? 5      -   5        $??LoginBtn??5   F   $??Log In??6V   
???????$??46,244,418,42q?6z   $
??Auto??6?   ??5      ?? *LoginCommand+??5      ?? 	 ?? ElementName$	 
LoginPanel??5      ?? 5      -   5        $??GuestBtn??5   o   $??
I am Guest??6   
???????$??350,244,114,42q?6?   $
??Auto??6?   ??6   ?? *GuestCommand+??6:   ?? $	 
LoginPanel??6?   5      
 ? Triggers
 5      :? 5       :? RoutedEvent$ Loaded??6   .[?5      ?? .??5      ?? .??5      W?  ?? 
TargetName$ panelBorder??5   !    ?? TargetProperty$ Width?5   !    W? From$ 0X?5   !   	 W? To$	 600X?5   !    g? Duration$ 0:0:2D?5   !   5       5!      5"      5#      5%      5&      5'      