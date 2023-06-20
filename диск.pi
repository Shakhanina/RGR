import sys
import csv
import pprint
from collections import deque
 
row = [-1, 0, 0, 1]
col = [0, -1, 1, 0]

def isValid(mat, visited, row, col):
    return (row >= 0) and (row < ctrok) and (col >= 0) and (col < ctolbez)  and mat[row][col] == 1 and not visited[row][col]
 

def Shortest_length(mat, start, end):
 
    i, j = start
    x, y = end
    if not mat or ctrok == 0 or mat[i][j] == 0 or mat[x][y] == 0:
        return -1
    (M, N) = (ctrok, ctolbez)
 
    visited = [[False for x in range(N)] for y in range(M)]

    q = deque()

    visited[i][j] = True

    q.append((i, j, 0))

    min_put = sys.maxsize

    while q:
        (i, j, dist) = q.popleft()
 
        if i == x and j == y:
            min_put = dist
            break
        for k in range(4):
            if isValid(mat, visited, i + row[k], j + col[k]):
                visited[i + row[k]][j + col[k]] = True
                q.append((i + row[k], j + col[k], dist + 1))
 
    if min_put != sys.maxsize:
        return min_put
    else:
        return -1
 
if __name__ == '__main__':
    file = open(r'C:\Users\shakh\OneDrive\Рабочий стол\Алгоритмизация и программирование\аа.txt').readlines()
    ctrok, ctolbez = int(file[0].split(' ')[0]), int(file[0].split(' ')[1])
    matriza = [[] for i in range(ctrok)]
    start = (0, 0)
    end = (0, 0)
    for i in range(1, len(file)):
        line = file[i]
        for j in range(len(line)):
            if line[j] == 'x':
                matriza[i - 1].append(0)
            if line[j] == ' ':
                matriza[i - 1].append(1)
            if line[j] == 'S':
                matriza[i - 1].append(1)
                start = (i - 1, j)
            if line[j] == 'F':
                matriza[i - 1].append(1)
                end = (i - 1, j)

    min_put = Shortest_length(matriza, start, end)
 
    if min_put != -1:
        print("Кратчайший путь", min_put)
    else:
        print("Пути нет")
