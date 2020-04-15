﻿using InternetClothesStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InternetClothesStore.Db
{
    public class DbContextInitializer : DropCreateDatabaseAlways<InternetStoreContext>
    {
        protected override void Seed(InternetStoreContext context)
        {
            Category categoryJackets = new Category { Name = "Куртки" };
            Category categoryPants = new Category { Name = "Брюки" };

            context.Categories.Add(categoryPants);
            context.Categories.Add(categoryPants);

            Image imageJacket1 = new Image { Path = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxAPEBEQEA0PDxAQGBESEBAPDw8PDxUSFRUWFhcSFRUYHSggGBolGxcVITEhJSkrLi4uFx8zODMsNygtLisBCgoKDg0OGxAQGi0lHyUuLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLf/AABEIARMAtwMBEQACEQEDEQH/xAAbAAEAAgMBAQAAAAAAAAAAAAAAAQQCAwUGB//EAEEQAAIBAgIFCQUFBwMFAAAAAAABAgMRBCESMUFRcQUGIjJhgZGhwRNSsbLwM2LC0eEjQmNyc4KSFLPxFRYkQ6L/xAAaAQEAAwEBAQAAAAAAAAAAAAAAAQIDBAUG/8QAOhEBAAIAAwQHBgQGAgMBAAAAAAECAxExBBIhQQVRYXGBscETMjNCkaEi0eHwFCNDcsLxRFI0YrIV/9oADAMBAAIRAxEAPwD6+QkAgAAAgAAAAQAAAAAAAAAAAAAAAAzAAQAAAQAAAAIAAAAAAAAAAAAAAAAZgAIAAAAEAAAACAAAAAAAAAAAAAAANgEAAIAAAIAAAAEAAAAAAAAAAAAAAAbAIAAAIAAQAAAGBAAAAAAAAAAAAASAAzAgAAAgABAAAAAgAAAAAAAAAAASAAAZgQAAAQAYEALgYzmlm2kt7aSImYjUiM9CnNSV4yUlvi014okSSgAAaquJhDrTjH+Z2GQ2RmnqafB3IzhOSQAEgAAAAAAzAAQAAgCAK2Nx1Oir1JWvqSzk+CMcbaMPBjO8tMPCviTlWHCxXOVv7OGjH35WcvDUeTjdL58MOMu2fyd2HsH/AGnwcrFY6VR9Kcp5pq7yXd4nl4u1XxZ/FbN20wa0jhClzd5aq4edanlKKkujLLJQjFO/BfA9SelbYeXDOMocs7BW0Z55S7dbnhox0nSgt2lUcFe9rXs7GuD0vGJaK+znwnOfJlibBuVz3oRT57U3BS9nHVfo1lOPc0sy9ulKxbKKW8kV6PtMZ70M5c6ptZUYq+Wbbdznt01/1p9/0aR0b12+zn4rHurGpUqPaklnbou90vDwJnbcW+z3vbn+GIj7/ZMbLSmLWte+fRU9u4qTvbe9SSPGi9s8q/Z3zSObp8lc5akYpVIupDVGTynbf2956mD0rbD/AA4kZ9vP9XFi7BW3Gs5PUYHH060bwerrReUk+1HtYG0YePXepP5w8zFwrYc5WW0bswhIAAAAMwDAgAwIAxnJJNvJLN8ERMxEZyRGc5Q+e47HuvVqVG9UkordFLJeZ8dtW0TjYk4k+Hc+hwcGMOkVhof2b4+pzZ/ha/MwcnFrW03YQnJWrWlPLJpLpLO6vqf1tOyL09ju2ju7J/KWcVtFs4/f6ufyupTh0Iqbi72k7J2TtbXtsdGwTTCxPaTyz/fcy2qlsSm5HNa5u4fQw9JTglOC6TaV78Tk2nE38a1ong2pWa0irdPE2a2u9ylcL8O9K0zxyhE8a56KcbRu9GKTztaytrbbz7jpvebViI5cuUfr1s64e7aZ625UHPpVNSa0Ya1xlvZy70RH4WnNbjHoriRyVmW3AY10qzaerWt8X/wdWy7RODixblz7mWPgxiYeX0e7wtZTimtp9bE5vAmMm4AAAASBkAAgABiwORzlxWhRcU+lPL+3aeb0pjbmDuxrbh4c3XsWHvYmc8nz/k+ppf6h/wARrwjBeh83ixlWvd6vcnkurqNGPJHNEl5aLITCnj6dpaSyaeuyeT138vA2pbWJTCZ0rrO6fYsr9yJw7zS2cImM4yUMHiZJ1KUnnFrX7rzX12HXibPWZi0e7MZ+H74M634drZSjOcrQ3Zya6K7O1/8ABliXjWfo0rGS7Rw+hVgnJyaTvJ2v5akZb2cE6Ll8nxM+Ss6t0F0UXjRXm5+nbEte9GL8JTXqi2X4IntX5PZc2sVdODecfgfS9HY3tMGInWODw9sw93Ez63oDvcoBIAABkAAgCAIA8TzgxjnWln0Y3iv7dfnc+U6Rx5xMaeqOEeH6vb2TCimHHXPF5vkeDUcRfbWm1waj+pzY85xX+2PV1Z8XQpros540J1ZRz0eDQjkmVXG6l9bi1VoWIq8Yt8CEc1OthI+0Ulo6U1Z5S0kk3k21ZrKWpvW722+nnP8ABR15/b/f2c0Z/wARPVkv0IpK/eebHHi6JlXv+2i+xl66JnRu/d7yvJXmsbkXUcrFZYqi9jjVT7nBr8Res/yrd8eq8O1ydi/ZVotPKTafxOzo7GnDxYjlPCXJtWFv4czzji9zRnpJM+neK2AAAADIAwIAgCvjq/s6U5+6m1x2edjHaMX2WFa/VC+FTfvFXz3EvJPtZ8Xbi+iqrYLOnKXvSk/CTj6FsThw7ITzWsMr37SlUWZ04eK/QmIJlTx6zjuZMc1qysU81YrHFE8GEdbfb+FnR/xo/u9IU/qT3R5tsnaK8ltMNIWjVXrq1WC+6y+lUw3qOS7fQqhtbz7i2auTm8px6dCW6bT4SpzXxUS9PdtHZ6wmNYXms09zT8mRW2X4o7JRMZ8HuORqulTifZ0tvViYfPWjKZh0CyoAAAZAAIAhgcbnRW0aOjtnJLuWf5Hl9LYm7gbvXLt2GmeJn1PGY92jwTZ8zMcYh7FVXkp/+PB+9d9zbkvJo02jheY7o+xHGXQwqy77mddEWTZKV9mY0k5KHKWJg/Z2kpJSz0bytk93A2ik5StVso11dNaW7qTXxRhFZif9JlnBpZ/eex7I/qdP/Hj+6fKGX9Se6GdTEwi7uM5Psg/UyyjnK2UyqVq16kJNSirSWcWtxO7O7K8aLdN3Taz3W7TOUM6uXfa5Mqwo8rPoRl7k6cnwU0n5NmuDxtl1xPkTwXYZpcCleMFtXqubNW8Lbj6vYL72BX6PD2uuWLLunY50gAAGQEAAMQPL86q16kIe6rvi3+iPnumMTPErTqjzersFcqTZ5TlypowqPdF/A8rDjPFiHoV0ThEoYejG17QgsuyKQx+N7T2yiqVUrNNrRprVn05/kvMrG7Xt+37+y0xxZUcKrpzlKpLJ3qO67o6l3In2kzOUcP39UTwhhVX13la6SusUlqKRqiWMM/GXyI6Z/wDHj+6fKrKPiT3Qmedn3HNPHi1jqYY3rR7vU15IqypUU27orWZJlliIOKum32Sd/PWWnLmiOKrjOnRqKzTcJ5bb2fqThTliRPaWjgtYSppQhLer+oiMpyRZ6DmzVtNx3nvdE3zpavU8vb68Ys9Uew85ISAAJAAQBAHhuVK/tMRUlsu0uEcvQ+P2zE9ptFrdvlwe9gU3MKIeX5z1H/p61tbjJLjaxTZOONXvdE8KurKOjGEdiVvQwvOc5oroX6Nu0pyW5t0F1eBaNYVlWqQum92vxL4dJmJnq9eCZtlMR1tlB3SM4TLGlr738qOn+hHfPlVn/Unuj1bacbx7zniM4XmcpaKqvPsV355Gs7vs4mNZzViZznwWKGtmdUyyxOpFrIq06CatvTXmUrOUrSr8i/YU09cVovjHovzR0YnxJ7/PipHuw7fI9TRqx7cjv6Mvu42XW5Nsrnh59T28XkfSPHZAAAEgGBDAr4yt7OnOfuxk++2XmZY2J7PDtfqhfDrvXiHgIvW+J8VD6KXD5azio+9OnH/KcV6m+ycL59k+ScT3Zdatr7kc0kMdhVK0v3TSOSjRTV7remhS0xnEc02jSUYdWdisTxWtoR1X7ZfKjpn4Ed8+VWUfEnuj1bqHV8TCui9tWL6hHynNOH1smupZOJ2E2KtcdnF/AqlW5KyVWPu1J+EpOS8pI6MWeMT2R+SkafV0qUrST3NGmBfcxIt2s8Su9SYe8wk9KCe9I+vh4DcAAASBDAhgcfnTX0aGjtm0u5Zv4I8zpbE3dn3eucvX0dmw0zxc+p5D92R8xyezzcbGrSnRj/Eg/wDF6Xob4E5RaeyU30dSrr8Pgc0kMWVStQ1RNY5KSrwfS8SnNedCHWXEiNSdGM380vlR1W+BXvn/ABZV+JPdHq3qVoeRz5/hXy4kl0CflOZhtbFNSycRrRNirXDV3oqlUwWVauve0J+MEvwM3vOdKz3x98/VSNZdFEwiXsuQaulRj2ZeB9Zst9/CrPY8LHru4kw6ZuyAAEgQwIA8rzur3qQh7qbfGX6I+d6ZxM71p1Rn9Xq9H0yrNutwKnU4s8fk9CNXMUb1ofd05eWj+I1rww7LW5OhV6zMJRCNHJvcREJlYw76PAvXRS2qttKLl8yOaeTCTz738qOu3wK98/4sq/Enuj1bn1YnLOjSNW6suj4GttFI1a6M7XKVnJaYTVeomeSIYRfxRCVWGWJf3oQ/+ZzT+ZG88cKOyZ+8for809zoRIjRWXpOa1bKUd2Z9F0XfPCmvVLydtrleJehPTcYBIEgQwMQPCcs1/aV6ktl2lwjl6Hx+3YntMe1u3L6cHv7NTdwqwo4nqrvZyTpDauqnhI3qN7kl4v9DSZ/Bl2rWWqnWfEylEJhLK3bd/kM8oMmeHewtVFmmasykrQghLWtfj8p1W+BXvt/iyj4k90eqxL91cDmnWGkaTLfVzsjWepSGuNPuWrtK5LNc35ZP68H3ixA3r7n5lZTCtXyxFN74VfmptfFm8fCnvj1U+aPH0dFbRGisupzeq6NZL3lY9fou+WJNeuHDttc6Z9T2B7zywCQAEMDTi63s6c5+6m/BGeNiezw7X6ozWw671or1vnrdz4mZzfRteN2LsE6po0cnK8pcY+V/wAy9tIhN22bzfeZTxIRR2Pfn3bPIX6ks6ObJhWxV37yEw1kJYQfS+tzOm3wa99v8WcfEnw9VhZyOb5l+TbKXS7jTPirlwI6+zL4ESQ04xWcXwjL0fp3k5ZxkmGK/MolpxPXpPfpR8Y3/Ca19y3h5/qjmvp+hNVJWcFU0akHuaO3Y77mNWe1zY9d7DmHu4u6R9S8VIEgAIYHI50VtHDtbZuMfV/A83pXE3NnmOuYj1dew03sXPqeOgrs+XiHtS0495smfeTTRhyWus+1/BFrci7Gpm9He8+G0pXhxWhskykDdhFrZeqlmMtS7yvJbm1AlhRXTZ0X+DXvt/ip8890eqzRV5HPXVadEXvpPfl4jrG1q3xL6KwwrWks9TVmM8pzWhVw7bSvrTafFZEXjKUteM10P53/ALdQvh+7bu9YROroR1LghVWWcXmbROUxLOYe8wFTSpwlvSPr6W3qxPW8C0ZTMLBZCQAEMDzfO2peVKG5Sm++yXqeF0zfOaU759HpdHxwtbweegs+9HiQ9FVx+tkT7zSmjDk6doN/zfGxa85T4InjKaK1vfq+vrUZz1LJIRLbQfRYz4IyTPqriORzaWQljR67+th1X+DXvt/ip88+Hq30XrfYc1Z1WsiLsl2u45Qltbyk95brV5tMle2eWv8AQckwxcdGa3S+Ky+FvBkzxjuTCryjKyo/1IeekvUvgRnn3Si2roU3ku/4laos2rUa6wzex5u1NKgvu3R9TsNt7Aq8Xaa5YsumdTBIACAPHc5K18RL7qjHy0n8T5jpS+e0THVER6+r2dirlhOXB59/oedDqVeUdvAj5l6aNeAa9kn2y4dZovi+9l3I5tuv0MNV0SRMIZ0P3l2BEpk+h3iPdObTfPxCUYZ9NvsOi3wa99vKqnzz3R6t0NUuHqc8c15J5W4CxDOeUUu8tyRza3K1hA0ym5STtkmrbOLHCFsmjlJXeHX8VPwjOXoa7Ppaez1hWdXRisl9bTOESzUktZpE8FJji9PzUq3jOPan5H0XRVs8KY6peTttcrxPY756bjAJYGLA+fcuVG6tR7faS8sj43bJmce89svodmjLDrHY1x1rizCF5VuU3ZX7Ccs7QtVp5LX7GPj4yb9S2P78+CIbc1dpXexN5GUSsmSe1LVsdwgoSzfbciSWUur3iNE82raEsYa+5nRb4Md9vKrOPfnujzlapNZ9tvMxrwzWli839bCusp0htVrNvaacs1OapWnopOybyWb1ERHBeIzltVO1r63s3GcphUxcm6lGNtWnJv8AtkvU3w+GHaf3qjm6NsolctFGlu8i86Iej5qztUlHsPZ6Ht71e5523xwiXqj3XmBCUgYgfO+WLadXepzfm/yPjdp44t++fN9Fs/uV7oYYd3s+xMxrC19VDl66pX3Z+Zrgx+OIlNZTyfiKehHRdrpK2d77cvUpiVtvTmlvqrK97GWSYniirNLW7Keir/DxJrEzwSmlk27X3ZlZjkM6slot9l3uJpWbTlEImcmqEL+YSKOfc/Cx0zGeBE/+0+UMo+JPdHnLZsb7L27Ec9Yz4NJHnmnserNZiY3bZSjWGOkraOnLLXkl5l6xaeEQiZiOLGpSurqMm1msnrWpJcS9cLEmd2Kz9JPaVjWYbIxqNX9nJu3Vs13XOnD6Mx7TxjKOuWNtrwojVWhhazmnUsnDSWim3nK2u/BGW0YcYVrYVWuHiRasWXWmkkzDdyM82MrKz7ibaIh2Ob1S1ddqf15Hp9EW/mzHY49uj+X4vZo+jeOBIBDA+ectQ0MTVg3ru13u/wCNHyO2Yc0x7R2+fF9Bs1t7BrLRgZ5aO2KjfwOeNWl+tVx+LhNOD6SfgWjeic4Iqr8j4V+3oxykoyWj0c9F7HvPU2H8WJprq59rn+X2volbkKhL/wBSXC68kerbYNntrSHlxtWNHzKtXm7SlrjdJprN60P4HZ93d3I/fbqRtWLE57yZc3ab3rg2ZT0Xs0/L95/NeNtxo5+SpjebcVCUtOVopu2X7uZhforCrE2iZjhPV+TWm3XtMRMQxwnN3q/tHqW7cWp0Tgazn9UX2/EzmIy/fiuw5s01rcn32OmNgwIpubvDPPWdfqxna8Wbb2fFhjub1GNKVlLXBPpS1OST8mzHE6O2elc4r1c5647WmHteLNspnr5R1T2M6XNylul2dJm0dH7PEZbvn+bKdrxZ5+SxR5CpReUEdNMKlIyrGTK2Ja052lcWAh7qLqZpWFitiA8ry/SqUq0mopxnaUXnuSa4o+Z6SpOHjTaY4W/09nY7VvhxHU49Wq31k8vdzPP3ol2RXJjJx0X0nnv19hKObp83Zt1afbn2nd0Zw2iI73Nt3wp8HvkfTvDAkAMIeA5dw1VYicnCei5S6Wi9FqTdnfsSXifL7bs+L7W9prOueeT3tmxcOaRETyc2th1oys2nJpdF7HZHBFpzdOrRh4qLc4q7bsr6uGrJFrTM8Fph6rmryPfRxE7Xd3GKVku0+m2HZYwqZ85eFtePN7bvKHrLHe4ywSiwFflFfsa39Op8rMsf4Vu6fJfC+JXvgw6XkjSuik6rJIqcqfZPjT/3ImWP7njHnDTB9/6+UrMTZkyISAQwhy+ceGU8PO6zh04vamv0uu84ukKRbZ7TPLj9HVsd5rix28HiVSV753y3L4HyszL3WLgklldK9s3lZ2JHS5vU37anaLyk72WWjnbPgeh0dW3t62iJy/RybZavs5jN70+meIAAAENAUcRyPQqO7pRT3xWi/IwvsuDec7VhrXHxa6WlR/7Vw3uyXCcrfEy//P2fPPd+8tP4zGy1+0OzRpKEVGKsoqyXYdjm1ZgAIAwrxvCS3xkvFMi0Z1mE1nKYV8A7wg98YPxSK4c50ieyE4kZWmO1bLqqvKn2UuMPniZ4/uT4ecNMH348fJYiasmRCQABjUpqScZJSi8mnmmiLVi0ZToRMxOcKX/RcPr9jHzMI2PAj5I+jadoxf8AtLbS5Nox6tKC/tRrXCpXSsfRnOJedZlajBLUkuCLqMkEgAAAAAAIAAAACwFDkn7KknrUIRfGKs/gY7NwwaxPVH24Ncf4lu+V42ZKvKn2Uv7PniZ43uT4ecNMH348fJvWs0ZtgAAAAAAJAAAAAAAAAQAAAGAAocm9XhKtH/GrNehlgTnTxt9rTDTG97wjyhfNWapyr9k+2VFeNWCMdonKnjX/AOoa4PveE+Ut61mzJsAAAAAAAAkAAAAAAACAAAAAApcnrJ/1MR51qhTDpuxl2zP1mZWvbenPsj7Rkul1WnF03JRSV+nTk+EZKV/FIiYidUxMxoziiUMwAAAAAAAJAAAAEAAAAAAAAAIsShJCQCAJAAAAAAAAASAAgAAAAAAAAAAgAAAAAAAABIAAAAAAAAAAAAQAAAAAAAAAAAAAABIAAAAAAAEASAAgAAAAAAAAAAAAAACQAAAB/9k=" };
            Image imageJacket2 = new Image { Path = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxITEhUTEhIVFhUXFRMWGBcYEhYWFxgXGBsXGxUYFRUYHSggGBolGxcVJTEhJSkrLi4uGB8zODMtNygtLisBCgoKDg0OGxAQGjAlHyAsOCs1NzcvNjcrNzUzNzg3KzcvMzcrMzc3NzArNS0rODc1LisrLi0rNzcrLS8tNy0rMP/AABEIAOEA4QMBIgACEQEDEQH/xAAcAAEAAQUBAQAAAAAAAAAAAAAAAwECBAUHBgj/xABFEAACAQIDAwkFBQQHCQAAAAAAAQIDEQQSIQUxQQYHEyJRYXGBkTJyobHBI0JS4fAUkrLxFRdUgpPR0hYzNDVDYnOio//EABgBAQADAQAAAAAAAAAAAAAAAAABAgME/8QALhEBAAIBAgMFBgcAAAAAAAAAAAECEQMSIUGhMVFhgfAicZGxwtEEExQyUrLB/9oADAMBAAIRAxEAPwDrQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAANHjOWOz6UpRqY2hGUW1KPSJtNb00ru67DB/rG2V/bIfuVf9AHqgeW/rF2V/bI/4dX/QSUOX+y57sdRXvNw/jSA9KCLDYmFSKnTnGcJK8ZRkpRa7VJaMlAAAAAAAAAAAAAAAAAAAAAAAAAAAAAa3be3cPhIZ69RR7I75y7oxWr+QGyNdtrbuGwkHPEVY01a6TfWfuxWr8kcp5Tc6GIq3hho9BD8TtKq147oeV33nO8RVlNuU5OUnvlJuUn4yerAs21seUK6k3lo1/tKVWSbjKE9VeS+8r2a4NEeLwDpTyOalZJ3Wm9X3M2uwttyoQlRrU1iMLN3lQk7ZW/vUp76cvD8zUbQjDpJSoZ1T0yxqNSlFW9nNHSSVnbuObSnW37b9kc+U/wCxPTunkvO3HAlDvIMXgXmhGMlUnNQahBNyvJJqLVva1tZF8qU3daJ+Nz0eC25RwlGMcBSksVJNVcTWUXKN1qsPGLahe76z18eFte9642RmZ+HnPd7syiuObrnNRCFDDywUqsZYilJzq0079G6mqgu21tbbm2j3J8q7Mq1KU+lhUnGrdvOpSU7vf1l28e06Nye508TTtHFU1Xj+ONo1V5ezP/18TWkTFYi05lEuyA1WwuUWGxcb0Kqk0ruD6s4+9B6+e7vNqWQAAAAAAAAAAAAAAAAAAAAABFisTCnCVSpJRhFOUpN2SS3tkpxrnc5UOrVeEpv7Ok1ns/bqdnhHd437EBmcoOdyTvHB0UlqukqvXxjTT+b8jm20NqVq03Uq1JTk98m7t/l3GHYSiBXMWVGXIo4gIIVF1W+4kjEPcBj4OSa0vbVa66aEyViDZq6vm/oZaiAUirnYq4jKBNQxkoNTi5RkndOMmpJ9zW46Dye51atNKGKpurFffjZVLd63S+BzhUy7KB9IcnuUOHxtN1KEr2dpRkrTi+GaPf2q6NqfOHJPb9TB4lVYXa3TjfScHa68eKfBn0VhMRGpCNSDvGcYyi+1SV0BKAAAAAAAAAAAAAAAAAAMPbGOVChVrPdTpzn45U2l6nzFia7lKUpO7cm2+1t3b9bndedraCp4CUL2lWnCC8E1OflaNv7xwGbAkc9StyCCRWncCdFCkWXoC+CKTX0JIoSX0+YDE01HLb8FN+bjFsokS19XH3IfwopYC/D15U5KcXZpPgmtU09H3Nmd/S0nfPSoyvd3dLX4PQ19gUtp1tOZhOZZ1TG0mtcNBN8YylFJ9qX0ua2at3l8txRz0JrWK9hlj8TuXNHtXpcI6Mn1qMrL3J9aPxzryRw21z3nNRtF09oRp8K0Jwa74rPF+WSS8yyHbwAAAAAAAAAAAAAAAAAByXn2xVpYSHdXk/8A5r/P0OTya/TOn8+zTr4VcVSq385Rt/CzlM1917uAElN6tea/XoS31Nam1OKvx+Bnw7QJEyREUCWAEkXqXtEa3l/5AS4jfH3I/ItRfiPuaf8ATj9dS1oCrLbFxa2ARHWjZN9hJJcSDHVep4tL6/QCOjO77j0/N9joUto4edTSObJfslVThG/decfU8xRjaKb8WS4fEyp/axtmi86urq61V/QD6oBDgsR0lOFRbpwhP95J8fEmAAAAAAAAAAAAAAAAA4NzxYrPtKcb/wC7pUYW8U5v+M8HVjdHoucbEZ9p4uSe6qo/4cYwa9Ys825gY1VaJ77NfyZkxd3bvMfEVV337bE+HqcHv/W4DJaK31KJ31KPeBMnqSJ/QifaSRfzAy8ZBro78acH26O+hDN6FaspPJm/BFR93W31LJLgBemGiiK2AR10MTFa2Xff0/mZdPi+wwsTU+004JLz1YFasi77ku+MvSzuR1Hf4F9F3eXfdSVu3RgfUezG+hpX39HTv45VcyS2nDKlHsSXpoXAAAAAAAAAAAAAAAAAfM/L2DhtHFxa16epLym88fWMk/M83KXboe453cdGrtKruXRqnRW67yrM2/70pLyR4WbfGN14gW1pWRSN7J+XkiGd3w0J+D8b+YGZSlp+u0vTIYPREqAngXUpfQjQiBsMfHq0e+kv45kD3FK1dyyJ/dgor1k/qUYFUy+LIm/kXQlcCSC09TXYn2/j8zIqPhuu/hvZrsZU69kuG5AZNSatZasycLC2retvQxaMLcLyfDgu4yMPhnOSi3vaXrogPqDZGL6WhSq/jpU5/vRTZlkWFw0acIU46RhGMF4RSS+CJQAAAAAAAAAAAAAAAAPnLnXo4f8ApOu6Us2Zx6S9rRqpWmovitFfseZHj5UVwv6sydqYeUa1VVYvpFUmpZt+bM81795jRTAgqcdWT65X4EWJVtFxMl+yo8X+m/iwLqe5eBfD6kMZEsXuAnuFv9CxyKxe/wAgMrF4fJl1vmpwn4Zr6eRY56EbquVr8IpeX6ZRcQLlIujKxG0MwFz1ku67+i+ZjZVmb46L4LcTweq8H9DHzdZ+IGVT0WiNjsFJ4mgnu6ejfwzxv8LmtpydjO2H/wARRtvdakvWcQPp9gMAAAAAAAAAAAAAAAAID5n5xqtSe08W6lk1VcErW6kUlT83BRdzzblY2vKzaDr4zEVW9ZVqvpF5YLyjGKNJd8dQIpSzSXiZUm3u/S4GLxMiE2t+4CROxJCRZvLk0gJpMrH6ojTuyubXzAkcHG19LqL8mlYuZXGYjO46WtTpx9EtSPNoBLwImyikGBWm91+23r+a+Jj059aS/wC5/Mkm3Z9u9eK/kRxtmuuKQGUr8Td8jaalj8KmtP2ijp4ST+hpM56PkLXhHH4ac11VWgvByvGL8pOL8gPowAAAAAAAAAAAAAAAAAAfKXLGhGGOxcKd8scTXS8pvTydzT+SOk87nImWFqVMbCopUq1ZuSk+vCpUcpNLS0oXTtxWm/ec0VUClRmyxeDqUpZK0JQnljLLJWeWSvF+DTPUc0fJOGPxUp1daOHyTlCyeeUm8kGn915ZX7lbibHn52gpY+nTVvsqEU/em5St+7l9QOfqRI5IxYzRKBNFlrlqWwaKWsBJGWuvYvgokimRzmr3Xd8kRyegE6mLmJGpuaJZ1QJpSI6EddHxsSbGpqtiaFF+zUrUqbfdOUYvXwZ6TnD5N/sOOqRjFxoVW6lHTSz9qC92Ttbsy9oGgvbivT8zacmKc6mLw8Ib5V6K7PvJt+SuavTeei5v8HUq7Qw/RRcslWnUnbTLCMlmlJ7lpfx3ID6PYAAAAAAAAAAAAAAAAAA8Hzx4CNfB06cq0aK6ZTzzjJw6sZq0pRTy+1vfYcVfJFcNo4Brt/aGvhlPqYo4rsXoYX09SbZrfHlC8WrEcYcz5neTssK68lKU4VIwvUdOVODlFvKqUZ9aaSlNuei1ilfU8zzy8mas8VLEUouTyxc4JXk4WtGpFfeSd4u2qtF7mdzNbtzYtPExSm5QnB3p1YPLUpy4uL7HZXi7p8ULad9sbbe1HHjz9+PUEWjPGOD5GB37a/IrF3blhcDjVb2mnhsRL3mk4t9914I89U5G/j5P1V/48dGXolMy/Uasfu0p8pifnMT0W2Vnst83K8M9CWe7eex5Rcj6qcHhdmYykrSzqS6S70y5XFu3Hf3GohyO2jLdgcRrovspLfprdHTp331i2JjwntZzGJw0zi03d9nyRZX0X67jcYrkvjoO0sHiNdVajOWmvGKdtz0MjY3JqvOtBV8DjZUnmzKnQmpPRuNpTSjvS3vcTadsTOCIzLymZ9r9Sh1ijyIov2dj7Qfv1qdP5zRtNncgJv2Nk0KXZLFYyVXz6KnmXk2jlj8VeezSt0j6mn5cfyjr9ngubXk1UxWLozacaUKsJOVvalF5lCPa+q27bknu0Oq8+mCnVwVJU6bnKOIU3lWaShkmpNJa2u4Xt3HqeTnJ39n69Sp0lXLlTUFTpU4aNwo0lpFNpXbu3Za2VjY7U2ZTrxUamZOLzRlCbhOEt14yjqtNGtzWjTNaxq7ZmcZnlyj139FZ258HyQlwv5X+h33mJoyjgaqlFxviZNXi03Ho6VnrvV0/ieh/2UqX/wCYYpeFPCJ+cuguzb7K2YqCa6WrUcrXlUmpPTdZRSjHfwQpbXm3t1rEeFpmf6wiYryn18WeADdUAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAB/9k=" };
            Image imagePants1 = new Image { Path = "data:image/jpeg;base64,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" };
            Image imagePants2 = new Image { Path = "data:image/jpeg;base64,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" };

            context.Images.Add(imagePants1);
            context.Images.Add(imageJacket1);
            context.Images.Add(imageJacket2);
            context.Images.Add(imagePants2);

            Purchase purchase = new Purchase { PurchaseDateTime = DateTime.Now };

            context.Purchases.Add(purchase);

            Client client1 = new Client { FirstName = "Alex", LastName = "Kurpatov", Address = "Minsk" };

            context.Clients.Add(client1);

            Item itemJacket1 = new Item {ClothingType = ClothingType.Cloth ,Sex = Sex.Unisex, Title="Желтая куртка", Description="Очень классная куртка, такая классная, что всем советуем.", Quantity=25, Price= 47.92 };
            Item itemJacket2 = new Item { ClothingType = ClothingType.Cloth, Sex = Sex.Female, Title="Хорошая куртка", Description="Куртка неплоха, можно поносить, рили", Quantity=19, Price= 35.92 };
            Item itemPants1 = new Item { ClothingType = ClothingType.Cloth, Sex =Sex.Female, Title="Штанишки", Description="Шутки шутками,а без штанов не проживешь. Покупай хорошие штаны в нашем магазине!", Quantity=10, Price= 25.5 };
            Item itemPants2 = new Item { ClothingType = ClothingType.Cloth, Sex = Sex.Female, Title="Волшебные штаны", Description="Как говорил Джейсон Стетхем: \"В штанах я король. Сейчас я в штанах\". Купите штаны.", Quantity=19, Price= 35.92 };

            itemJacket1.Purchases.Add(purchase);
            itemJacket1.Images.Add(imageJacket1);
            itemJacket1.Category = categoryJackets;
            
            itemJacket2.Purchases.Add(purchase);
            itemJacket2.Images.Add(imageJacket2);
            itemJacket2.Category = categoryJackets;

            itemPants1.Purchases.Add(purchase);
            itemPants1.Images.Add(imagePants1);
            itemPants1.Category = categoryPants;

            itemPants2.Purchases.Add(purchase);
            itemPants2.Images.Add(imagePants2);
            itemPants2.Category = categoryPants;

            context.Items.Add(itemJacket1);
            context.Items.Add(itemJacket2);
            context.Items.Add(itemPants1);
            context.Items.Add(itemPants2);
            context.SaveChanges();
        }
    }
}