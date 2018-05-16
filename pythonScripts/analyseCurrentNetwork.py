import pydivert

def AnalysePackets():

    print("Start")

    IPList = GetIPList()
    PortList = GetPortList()


    """54915"""

    with pydivert.WinDivert() as w:
        for packet in w:
            if str(packet.src_port) in PortList or str(packet.dst_port) in PortList:
                print(packet.src_addr, packet.src_port," ---> ",packet.dst_addr, packet.dst_port," --> Dropped")
                break
            else:
                w.send(packet)

                print(packet.src_addr, packet.src_port," ---> ",packet.dst_addr, packet.dst_port)

    print("Done")

    i = input("POTATO")


def GetIPList():
    IPList = []
    with open('ListIP.txt', 'r') as ListIPFile:
        IPString = ListIPFile.read()
        IPList = IPString.split("\n")

    IPList = IPList[:-1]

    return IPList


def GetPortList():
    PortList = []
    with open('ListPort.txt', 'r') as ListPortFile:
        PortString = ListPortFile.read()
        PortList = PortString.split("\n")

    PortList = PortList[:-1]

    return PortList

AnalysePackets()