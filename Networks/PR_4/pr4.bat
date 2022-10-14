route print
route -p add 192.168.0.0 mask 255.255.0.0 192.168.0.16 metric 25
route add 192.168.0.0 mask 255.255.0.0 192.168.0.16
route print
route delete 192.168.0.0 mask 255.255.0.0
tracert 192.168.0.16
arp -a
ipconfig /all
pause
