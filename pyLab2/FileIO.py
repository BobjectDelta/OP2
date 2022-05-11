from datetime import datetime
import pickle


def inputItems():
    items = []
    flag = True
    ctrlLine = "^D"
    while flag:
        print("Enter item attributes (name, value, production date, expire date)")
        print("Press CTRL+D+ENTER to stop input")
        buffer = input()
        if not buffer == ctrlLine:
            name = buffer
            value = float(input())
            date1 = input()
            date2 = input()
            productionDate = datetime.strptime(date1, "%d.%m.%Y").date()
            expireDate = datetime.strptime(date2, "%d.%m.%Y").date()
            while not(productionDate < expireDate and datetime.today().date() >= productionDate):
                print("Date error. Enter production and expire dates again.")
                productionDate = datetime.strptime(input(), "%d.%m.%Y").date()
                expireDate = datetime.strptime(input(), "%d.%m.%Y").date()
            items.append(name + " " + str(value) + " " + datetime.strftime(productionDate, "%d.%m.%Y") + " " +
                                datetime.strftime(expireDate, "%d.%m.%Y"))
        else:
            flag = False
    return items


def fillFile(items, path):
    print("Enter R to rewrite file or A to append it:")
    mode = input()
    previousItems = []
    if mode == "A":
        with open(path, "rb") as file:
            previousItems = pickle.load(file)
            for item in items:
                previousItems.append(item)
        with open(path, "wb") as file:
            pickle.dump(previousItems, file)
    else:
        with open(path, "wb") as file:
            pickle.dump(items, file)


def readFile(path):
    items = []
    with open(path, "rb") as file:
        items = pickle.load(file)
    return items


def outputFile(path):
    with open(path, "rb") as file:
        items = pickle.load(file)
    for item in items:
        print(item)
