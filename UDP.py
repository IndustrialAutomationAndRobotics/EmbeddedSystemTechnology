import socket

class UDP:

    def __init__(self, ipaddress, socketNum):

        self.IPADDR = ipaddress
        self.PORTNUM = socketNum


    def sendData(self, message):
        s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM, 0)

        #s.connect((self.IPADDR,self.PORTNUM))



        s.sendto(bytes(message,"utf-8"), (self.IPADDR,self.PORTNUM))


        s.close()

