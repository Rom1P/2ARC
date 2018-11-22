import pydivert


def AnalysePackets():
    print("Start")

    try:
        IPList = GetIPList()

    except:
        IPList = []

    try:
        PortList = GetPortList()
    except:
        PortList = []

    with open('..\\..\\pythonScripts\\ListBlocked.txt', 'w') as ListBlocked:
        ListBlocked.write("")

    '''Get All packets and check if IP/Port of Source/Destination are in rules. In this case they will be dropped and 
    them information will be wrote to the file '''
    with pydivert.WinDivert() as w:
        for packet in w:
            if str(packet.src_port) in PortList or str(packet.dst_port) in PortList:
                print(packet.src_addr, " : ", packet.src_port, " ---> ", packet.dst_addr, " : ", packet.dst_port,
                      " --> Dropped For Port")

                with open('..\\..\\pythonScripts\\ListBlocked.txt', 'a') as ListBlocked:
                    ListBlocked.write(
                        str(packet.src_addr) + " : " + str(packet.src_port) + " ---> " + str(
                            packet.dst_addr) + " : " + str(
                            packet.dst_port) + " --> Dropped For Port \n")

            elif str(packet.src_addr) in IPList or str(packet.dst_addr) in IPList:
                print(packet.src_addr, packet.src_port, " ---> ", packet.dst_addr, packet.dst_port,
                      " --> Dropped for IP")

                with open('..\\..\\pythonScripts\\ListBlocked.txt', 'a') as ListBlocked:
                    ListBlocked.write(
                        str(packet.src_addr) + str(packet.src_port) + " ---> " + str(packet.dst_addr) + str(
                            packet.dst_port) + " --> Dropped For IP \n")

            else:
                '''Drop of packets means we doesn't reinject him in the windows network stack'''
                w.send(packet)
                print(packet.src_addr, packet.src_port, " ---> ", packet.dst_addr, packet.dst_port)

    print("Done")

'''Get Rules'''

def GetIPList():
    IPList = []
    with open('..\\..\\pythonScripts\\ListIP.txt', 'r') as ListIPFile:
        IPString = ListIPFile.read()
        IPList = IPString.split("\n")

    IPList = IPList[:-1]

    return IPList


def GetPortList():
    PortList = []
    with open('..\\..\\pythonScripts\\ListPort.txt', 'r') as ListPortFile:
        PortString = ListPortFile.read()
        PortList = PortString.split("\n")

    PortList = PortList[:-1]

    return PortList


AnalysePackets()
