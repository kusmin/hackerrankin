#!/bin/python3

import math
import os
import random
import re
import sys


#
# Complete the 'miniMaxSum' function below.
#
# The function accepts INTEGER_ARRAY arr as parameter.
#

def miniMaxSum(arr):
    valueTotal = sum(arr)
    max_value = max(arr)
    min_value = min(arr)
    print('{} {}'.format(valueTotal - max_value, valueTotal - min_value))


if __name__ == '__main__':
    arr = list(map(int, input().rstrip().split()))

    miniMaxSum(arr)
