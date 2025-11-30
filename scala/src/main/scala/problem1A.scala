import scala.io.StdIn

object problem1A {
  def main(args: Array[String]): Unit = {
    val Array(n, m, a) = StdIn.readLine().split(" ").map(_.toLong)

    val tilesN = (n + a - 1) / a
    val tilesM = (m + a - 1) / a

    println(tilesN * tilesM)
  }
}
