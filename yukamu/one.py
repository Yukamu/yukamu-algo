__author__ = 'yukamu'


def one_one(a, b, c, d):
    """
    四値の数字を受け取って、最大値を返す
    """
    # 1. 最大値をaの値で仮置きする
    max_num = a
    # 2. bの値と比較する
    if b > max_num:
        # 3. bの方が大きかったら最大値をbで上書き
        max_num = b
    # 4. cの値と比較する
    if c > max_num:
        # 5. cの方が大きかったら最大値をcで上書き
        max_num = c
    # 6. dの値と比較する
    if d > max_num:
    # 7. dの方が大きかったら最大値をdで上書き
        max_num = d
    # 8. 最大値を返す
    return max_num