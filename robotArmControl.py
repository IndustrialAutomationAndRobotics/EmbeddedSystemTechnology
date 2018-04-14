import serial
import UDP

udpConnection = UDP.UDP("127.0.0.1", 8080)

udpConnection.sendData('hello lagi')

try:
    arduino = serial.Serial("COM40",timeout=1)
    print('Port connected')
except:
    print('Please Check the port')

while True:
    if(arduino.inWaiting()>0):
        data = arduino.readline()
        dataInt = int(data)
        #print(dataInt)
        code = dataInt//1000
        if(code < 49):
            if(dataInt == 89):
                print("robot on")
            elif(dataInt == 78):
                print("robot off")
        else:
            if(code == 49):
                temp = code*1000
                value = dataInt - temp
                print("base " + str(value))
            elif(code == 50):
                temp = code*1000
                value = dataInt - temp
                print("shoulder " + str(value))
            elif(code == 51):
                temp = code*1000
                value = dataInt - temp
                print("elbow " + str(value))
            elif(code == 52):
                temp = code*1000
                value = dataInt - temp
                print("wrist " + str(value))
            elif(code == 53):
                temp = code*1000
                value = dataInt - temp
                print("gripper " + str(value))


