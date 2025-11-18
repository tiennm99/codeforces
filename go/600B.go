package main

import (
	"bufio"
	"fmt"
	"os"
	"sort"
)

func main() {
	in := bufio.NewReader(os.Stdin)
	var n, m int
	fmt.Fscan(in, &n, &m)

	a := make([]int, n)
	for i := range a {
		fmt.Fscan(in, &a[i])
	}
	sort.Ints(a)

	out := bufio.NewWriter(os.Stdout)
	for i := 0; i < m; i++ {
		var x int
		fmt.Fscan(in, &x)

		pos := sort.SearchInts(a, x+1)

		fmt.Fprint(out, pos)
		if i+1 < m {
			fmt.Fprint(out, " ")
		}
	}
	out.Flush()
}
