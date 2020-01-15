<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version = "1.0"
      xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output
          method ="html"></xsl:output>
        <xsl:template match="/">
        <html>
          <body>
            <table border="1">
              <TR>
                <th>Dish</th>
                <th>Cuisine</th>
                
                <th>Weight</th>
                <th>Description</th>
                <th>Price</th>
              </TR>
              <xsl:for-each select ="Menu/Food">
                <tr>
                  <td>
                    <xsl:value-of select ="@Dish"/>
                      </td>
                  <td>
                    <xsl:value-of select ="@Cuisine"/>
                      </td>
                  
                  <td>
                    <xsl:value-of select ="@Weight"/>
                      </td>
                  <td>
                    <xsl:value-of select ="@Description"/>
                      </td>
                  <td>
                    <xsl:value-of select ="@Price"/>
                      </td>
                </tr>
              </xsl:for-each>
            </table>
          </body>
        </html>
      </xsl:template>
</xsl:stylesheet>
