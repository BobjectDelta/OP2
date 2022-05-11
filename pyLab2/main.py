import FileIO
import FileEditing


path = "C:/Users/pavle/Desktop/Lab2/pyitems.txt"
editedPath = "C:/Users/pavle/Desktop/Lab2/pyeditedItems.txt"

items = FileIO.inputItems()
FileIO.fillFile(items, path)
print("List of all items:")
FileIO.outputFile(path)

editedItems = FileEditing.EditItemList(items)
FileIO.fillFile(editedItems, editedPath)
print("List of items that will expire soon or have already expired:")
FileIO.outputFile(editedPath)

FileEditing.PrintList(FileEditing.GetLastDaysItems(FileIO.readFile(path)))
