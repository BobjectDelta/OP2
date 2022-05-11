import  FileIO
from datetime import datetime


def EditItemList(items):
    editedItems = []
    for item in items:
        data = item.split()
        prodDate = datetime.strptime(data[2], "%d.%m.%Y").date()
        expireDate = datetime.strptime(data[3], "%d.%m.%Y").date()
        prodExpireInterval = (expireDate - prodDate).days
        todayExpireInterval = (expireDate - (datetime.today()).date()).days

        if todayExpireInterval < prodExpireInterval/10:
            editedItems.append(item)
    return editedItems


def GetLastDaysItems(previousItems):
    lastDaysItems = []
    print("List of items that were produced within 10 days:")
    for item in previousItems:
        data = item.split()
        prodDate = datetime.strptime(data[2], "%d.%m.%Y").date()
        if (datetime.today().date() - prodDate).days <= 10:
            lastDaysItems.append(item)
    return lastDaysItems


def PrintList(items):
    for item in items:
        data = item.split()
        print(data[0] + ' ' + data[1] + ' ' + data[2] + ' ' + data[3])
