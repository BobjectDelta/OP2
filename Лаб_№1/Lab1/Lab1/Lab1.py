import FileIO as FileIO
import FileEdit as FileEdit

path = "C:/Users/nickp/Desktop/Лаби ОП/2 семестр/Лаб_№1/pyfile.txt"
edit_path = "C:/Users/nickp/Desktop/Лаби ОП/2 семестр/Лаб_№1/editpy_file.txt"

text = FileIO.FileInput()
FileEdit.FillFile(text, path)

new_text = FileEdit.FileEdit(path)
FileEdit.FillFile(new_text, edit_path)

print("Initial file:")
FileIO.FileOutput(path)
print("Edited file:")
FileIO.FileOutput(edit_path)
