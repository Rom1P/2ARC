import pydivert

def AnalysePackets():

    print("Start")

    with pydivert.WinDivert() as w:
        for packet in w:
            if packet.dst_port == 1234:
                print(">") # packet to the server
                packet.dst_port = 80
            if packet.src_port == 80:
                print("<") # reply from the server
                packet.src_port = 1234

            print(packet.src_addr, packet.src_port)
            print(packet.dst_addr, packet.dst_port)
            w.send(packet)

    print("Done")

    i = input("POTATO")


def GetIPList():
    IPList = []
    with open('ListIP.txt', 'r') as ListIPFile:
        IPString = ListIPFile.read()
        IPList = IPString.split("\n")

    IPList = IPList[:-1]

    print(IPList)

GetIPList()