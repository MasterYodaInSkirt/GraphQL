using System.Collections.Generic;
using GraphQL;
using System.Linq;

public class Query
{
    [GraphQLMetadata("jedis")]
    public IEnumerable<Jedi> GetJedis()
    {
        return new List<Jedi>{
            new Jedi(){ Name ="Luke", Side="Light", Id = 1},
            new Jedi(){ Name ="Yoda", Side="Light", Id = 2},
            new Jedi(){ Name ="Darth Vader", Side="Dark", Id = 3}
        };
    }
    // GraphQLMetadata -> attribute to customize the mapping to the specific schema type
    [GraphQLMetadata("hello")]
    public string GetHello()
    {
        return "Hello Query class";
    }

    [GraphQLMetadata("jedi")]
    public Jedi GetJedi(int id)
    {
        var jedis = GetJedis();
        return jedis.SingleOrDefault(x => x.Id == id );
    }

}