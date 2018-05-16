# If scapy module is not install please use:
# pip install scapy

from scapy.all import *


def getPacketsFromFile(filePath):
    try:
        # packets = rdpcap('9p.cap')
        packets = rdpcap(filePath)
        return packets
    except IOError as e:
        print(e)


def formattedSummary(packets):
    try:
        for i in range(0, len(packets)):
            getPacketInfo(packets[i])
    except Exception as e:
        print(e)


def returnProtocolType(pValue):
    protocol = 'ukn'
    # Those numbers are not magic, jsut designate by RFC & IANA
    if (pValue == 6):
        protocol = 'TCP'
    elif (pValue == 17):
        protocol = 'UDP'
    else:
        protocol = 'UKN'
    return protocol


def getPacketInfo(packet):
    # 0 TYPE | 1 IP Src | 2 PORT Src | 3 IP Dst | 4 PORT Dst
    pType = returnProtocolType(packet['IP'].proto)
    ipSrc = packet['IP'].src
    pSrc = packet['IP'][pType].sport
    ipDst = packet['IP'].dst
    pDst = packet['IP'][pType].dport

    packetInfo = [pType, ipSrc, pSrc, ipDst, pDst]
    with open('..\\..\\pythonScripts\\readFileConverted.txt', 'a') as fileConverted:
        fileConverted.write(str(packetInfo)+"\n")

    # Enter the file to the .cap file, if file is in the same directory simply write the file name.cap


def readFunction():
    filePath = ""

    with open('..\\..\\pythonScripts\\filePath.txt', 'r') as filePathfile:
        filePath = filePathfile.read()

    packets = getPacketsFromFile(filePath)

    with open('..\\..\\pythonScripts\\readFileConverted.txt', 'w') as fileConverted:
        fileConverted.write("")
    # Uses Scapy to fetch data for each packet and stores them in an array
    formattedSummary(packets)

    print('potato')


readFunction()
