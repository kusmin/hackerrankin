#!/bin/python3

import math
import os
import random
import re
import sys


#
# Complete the 'plusMinus' function below.
#
# The function accepts INTEGER_ARRAY arr as parameter.
#

def plusMinus(arr):
    positives = 0
    negatives = 0
    neutros = 0
    tamanho = len(arr)
    for value in arr:
        if value > 0:
            positives = positives + 1
        elif value < 0:
            negatives = negatives + 1
        else:
            neutros = neutros + 1
    print(round(positives / tamanho, 6))
    print(round(negatives / tamanho, 6))
    print(round(neutros / tamanho, 6))


if __name__ == '__main__':
    n = int(input().strip())

    arr = list(map(int, input().rstrip().split()))

    plusMinus(arr)
