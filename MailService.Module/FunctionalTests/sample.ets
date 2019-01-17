;#DropDB MailServiceEasyTest

#Application MailService.Win
#Application MailService.Web
#IfDef MailService.Win

*Action About...
 
*Action OK

#EndIf

#IfDef MailService.Web
!Action Navigation(My Details)
#EndIf
