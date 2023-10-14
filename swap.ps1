az webapp deployment slot swap -g $(resourceGroup) -n $(nameofwebapp) --slot staging --target-slot production

