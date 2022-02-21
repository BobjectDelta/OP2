def FillFile(text, path):
    print("Enter A to append or R to rewrite")
    flag = input()
    if flag == "R":
        file = open(path, 'w')
        for i in range(0, len(text)):
            file.write(text[i] + "\n")
        file.close()
    elif flag == "A":
        file = open(path, 'a')
        for i in range(0, len(text)):
            file.write(text[i] + "\n")
        file.close()

def FileEdit(path):
    file = open(path, 'r')
    new_text = file.readlines()

    for i in range(0, len(new_text)):
        flag = True
        j = 0
        string = new_text[i]
        print("String length is:", len(string)-1)
        print("Enter wanted length: ")
        wanted_len = int(input()) + 1

        if wanted_len > len(string):
            while wanted_len != len(string) and j<len(string):
                g = 0
                while g < len(string) and flag:
                    if string[g] == ' ':
                        string = string[:g] + ' ' + string[g:]
                        while string[g] == ' ':
                            g += 1
                    if wanted_len == len(string):
                        flag = False
                    else:
                        flag = True
                    g += 1
                    if not (" " in string):
                        flag = False
                j += 1
        new_text[i] = string[:-1]
    return new_text
