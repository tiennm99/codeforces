package main

import (
	"bufio"
	"fmt"
	"os"
)

func main() {
	in := bufio.NewReader(os.Stdin)
	var n, m, a int64
	fmt.Fscan(in, &n, &m, &a)

	tilesN := (n + a - 1) / a
	tilesM := (m + a - 1) / a

	fmt.Println(tilesN * tilesM)
}
