def FileInput():
    flag = True
    ctrl_line = "\u0004"
    text = []    
    while flag:
        print("Enter your string (press CTRL+D+ENTER to end input): ")
        string = input()
        if string != ctrl_line:
            text.append(string)
        else:
            flag = False
    return text

def FileOutput(path):
    file = open(path, 'r')
    print(file.read())
